using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


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

        public DataTable ComprehensiveSearch(string searchText)
        {
            try
            {
                Console.WriteLine("ComprehensiveSearch method started...");

                // Define  SQL query for a comprehensive search
                string sqlQuery = "SELECT * FROM Companies WHERE " +
                    "[company_name] LIKE @SearchText OR " +
                    "[company_website] LIKE @SearchText OR " +
                    "EXISTS (SELECT 1 FROM Products_Table WHERE Companies.company_id = Products.company_id AND " +
                    "(description LIKE @SearchText OR cloud LIKE @SearchText OR software_name LIKE @SearchText))";

                Console.WriteLine("SQL Query: " + sqlQuery);

                // Create a SqlCommand object with parameters
                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection.getDBConnection()))
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
        }
    }

}

