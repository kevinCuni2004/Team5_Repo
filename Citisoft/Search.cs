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

        // searching suitable vendors in database 
        public SqlDataReader SearchVendors(string searchText, string cityFilter, string countryFilter)
        {
            string[] keywords = searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //building the query based on keywords
            StringBuilder sqlQuery = new StringBuilder("SELECT DISTINCT [Companies].* FROM [Companies]");
            sqlQuery.Append(" INNER JOIN [Locations] ON [Companies].[company_id] = [Locations].[company_id]");

            sqlQuery.Append(" WHERE");

            AppendKeywordConditions(sqlQuery, keywords);

            // filtering option city
            if (!string.IsNullOrEmpty(cityFilter))
            {
                sqlQuery.Append(" AND [Locations].[city] = @CityFilter");
            }

            // filtering option country
            if (!string.IsNullOrEmpty(countryFilter))
            {
                sqlQuery.Append(" AND [Locations].[country] = @CountryFilter");
            }
            

            SqlCommand command = new SqlCommand(sqlQuery.ToString());

            // adding value to the parameter of keywords
            for (int i = 0; i < keywords.Length; i++) // ables to make multy words search
            {
                command.Parameters.AddWithValue($"@SearchText{i}", $"%{keywords[i]}%");
            }

            // adding value to the parameter of cities
            if (!string.IsNullOrEmpty(cityFilter))
            {
                command.Parameters.AddWithValue("@CityFilter", cityFilter);
            }

            // adding value to the parameter of countries
            if (!string.IsNullOrEmpty(countryFilter))
            {
                command.Parameters.AddWithValue("@CountryFilter", countryFilter);
            }


            return dbConnection.ExcecuteReader(command);
        }


        // slpiting big query into smaller pieces
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


        // adding queries to search info about company and website
        private void AppendCompanyConditions(StringBuilder sqlQuery, int index)
        {
            sqlQuery.Append($"[company_name] LIKE @SearchText{index} OR " +
                    $"[company_website] LIKE @SearchText{index}");
        }

        // adding queries to search info about products
        private void AppendProductConditions(StringBuilder sqlQuery, int index)
        {
            sqlQuery.Append($"EXISTS (SELECT 1 FROM [Products] WHERE [Companies].[company_id] = [Products].[company_id] AND " +
                $"([description] LIKE @SearchText{index} OR [cloud] LIKE @SearchText{index} OR [software_name] LIKE @SearchText{index}))");
        }

        // adding queries to search info about locations
        private void AppendLocationConditions(StringBuilder sqlQuery, int index)
        {
            sqlQuery.Append($"EXISTS (SELECT 1 FROM [Locations] WHERE [Companies].[company_id] = [Locations].[company_id] AND " +
                $"([city] LIKE @SearchText{index} OR [country] LIKE @SearchText{index}))");
        }

  
        // fetching the cities into combobox to display 
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

        // fetching the countries into combobox to display 
        public List<string> GetDistinctCountries()
        {
            string query = "SELECT DISTINCT [country] FROM [Locations]";
            return GetDistinctValues(query, dbConnection.GetConnectionString());
        }


        // reading the database to get information from coloums
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

