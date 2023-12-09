using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;
using System.Net.NetworkInformation;


namespace Citisoft
{
    public class Search
    {
        private DBConnection dbConnection;

        public Search()
        {
            dbConnection = DBConnection.getInstance();

        }

        public SqlDataReader SearchVendors(string searchText, string cityFilter, string countryFilter)
        {
            string[] keywords = searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sqlQuery = new StringBuilder("SELECT * FROM [Companies] WHERE");

            AppendKeywordConditions(sqlQuery, keywords);

            if (!string.IsNullOrEmpty(cityFilter))
            {
                sqlQuery.Append(" AND [city] = @CityFilter");
            }

            if (!string.IsNullOrEmpty(countryFilter))
            {
                sqlQuery.Append(" AND [country] = @CountryFilter");
            }
            

            SqlCommand command = new SqlCommand(sqlQuery.ToString());

            for (int i = 0; i < keywords.Length; i++)
            {
                command.Parameters.AddWithValue($"@SearchText{i}", $"%{keywords[i]}%");
            }

            if (!string.IsNullOrEmpty(cityFilter))
            {
                command.Parameters.AddWithValue("@CityFilter", cityFilter);
            }

            if (!string.IsNullOrEmpty(countryFilter))
            {
                command.Parameters.AddWithValue("@CountryFilter", countryFilter);
            }


            return dbConnection.ExcecuteReader(command);
        }

        private void AppendKeywordConditions(StringBuilder sqlQuery, string[] keywords)
        {
            for(int i = 0; i < keywords.Length; i++)
            {
                sqlQuery.Append($"(");
                AppendCompanyConditions(sqlQuery, i);
                sqlQuery.Append($" OR ");
                AppendProductConditions(sqlQuery, i);
                sqlQuery.Append($" OR ");
                AppendLocationConditions(sqlQuery, i);
                sqlQuery.Append($")");

                if (i< keywords.Length - 1)
                {
                    sqlQuery.Append(" AND ");
                }
            }
        }


        private void AppendCompanyConditions(StringBuilder sqlQuery, int index)
        {
            sqlQuery.Append($"[company_name] LIKE @SearchText{index} OR " +
                    $"[company_website] LIKE @SearchText{index}");
        }

        private void AppendProductConditions(StringBuilder sqlQuery, int index)
        {
            sqlQuery.Append($"EXISTS (SELECT 1 FROM [Products] WHERE [Companies].[company_id] = [Products].[company_id] AND " +
                $"([description] LIKE @SearchText{index} OR [cloud] LIKE @SearchText{index} OR [software_name] LIKE @SearchText{index}))");
        }

        private void AppendLocationConditions(StringBuilder sqlQuery, int index)
        {
            sqlQuery.Append($"EXISTS (SELECT 1 FROM [Locations] WHERE [Companies].[company_id] = [Locations].[company_id] AND " +
                $"([city] LIKE @SearchText{index} OR [country] LIKE @SearchText{index}))");
        }

        private DataTable GetDataFromDatabase(string query, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
                return null;
            }


        }

        public List<string> GetDistinctCities()
        {
            try
            {
                string query = "SELECT DISTINCT [city] FROM [Locations]";
                return GetDistinctValues(query, dbConnection.GetConnectionString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching cities" + ex.Message);
                return new List<string>();
            }
           
        }

        public List<string> GetDistinctCountries()
        {
            string query = "SELECT DISTINCT [country] FROM [Locations]";
            return GetDistinctValues(query, dbConnection.GetConnectionString());
        }

        private List<string> GetDistinctValues(string query, string connectionString)
        {
            List<string> values = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            values.Add(value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching distinct values: " + ex.Message);
            }

            return values;
        }

    }

}

