using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;


//taya is currently working on this class, please do not change anything here
namespace Citisoft
{
    public class Search
    {
        private DBConnection dbConnection;

        public Search()
        {
            dbConnection = DBConnection.getInstance();

        }

        public SqlDataReader SearchVendors(string searchText)
        {
            string[] keywords = searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sqlQuery = new StringBuilder("SELECT * FROM [Companies] WHERE");
            for(int i = 0; i < keywords.Length; i++)
            {
                sqlQuery.Append($"[company_name] LIKE @SearchText{i} OR " +
                    "[company_website] LIKE @SearchText{i} OR " +
                    "EXISTS (SELECT 1 FROM [Products] WHERE [Companies].[company_id] = [Products].[company_id] AND " +
                    "([description] LIKE @SearchText{i} OR [cloud] LIKE @SearchText{i} OR [software_name] LIKE @SearchText{i}))");

                if (i < keywords.Length - 1)
                {
                    sqlQuery.Append(" AND ");
                }


            }
           
            SqlCommand command = new SqlCommand(sqlQuery.ToString());

            for (int i =0; i <keywords.Length; i++)
            {
                command.Parameters.AddWithValue($"@SearchText{i}", $"%{keywords[i]}%");
            }
           
            //SqlDataReader reader = dbConnection.ExcecuteReader(command)
            return dbConnection.ExcecuteReader(command);
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

        /*public DataTable ComprehensiveSearch(string searchText)
        {
            try
            {
                Console.WriteLine("ComprehensiveSearch method started...");

                // Define  SQL query for a comprehensive search
                string sqlQuery = "SELECT * FROM [Companies] WHERE " +
                    "[company_name] LIKE @SearchText OR " +
                    "[company_website] LIKE @SearchText OR " +
                    "EXISTS (SELECT 1 FROM [Products] WHERE [Companies].[company_id] = [Products].[company_id] AND " +
                    "([description] LIKE @SearchText OR [cloud] LIKE @SearchText OR [software_name] LIKE @SearchText))";

                Console.WriteLine("SQL Query: " + sqlQuery);
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.DBConnectionString);
                // Create a SqlCommand object with parameters
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    Console.WriteLine("Parameters added to SqlCommand...");

                    // Create a data adapter to fill a DataTable
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        Console.WriteLine("DataTable filled with search results...");

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ComprehensiveSearch: " + ex.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("ComprehensiveSearch method finished...");
            }
        }*/
    }

}

