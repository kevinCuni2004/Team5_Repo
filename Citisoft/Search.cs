using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


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

        public DataTable SearchInDatabase(string companyName, DateTime dateJoined, DateTime lastReviewed, DateTime lastDemoDate, DateTime establishedDate, string companyWebsite, string numberOfEmployees)
        {
            try
            {
                Console.WriteLine("SearchInDatabase method started...");

                // Define your SQL query for searching in the "Companies" table
                string sqlQuery = "SELECT * FROM Companies WHERE " +
                    "company_name LIKE @CompanyName AND " +
                    "date_joined = @DateJoined AND " +
                    "last_reviewed = @LastReviewed AND " +
                    "last_demo_date = @LastDemoDate AND " +
                    "established_date = @EstablishedDate AND " +
                    "company_website LIKE @CompanyWebsite AND " +
                    "number_of_employees LIKE @NumberOfEmployees;";

                Console.WriteLine("SQL Query: " + sqlQuery);

                // Create a SqlCommand object with parameters
                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection.getDBConnection()))
                {
                    command.Parameters.AddWithValue("@CompanyName", "%" + companyName + "%");
                    command.Parameters.AddWithValue("@DateJoined", dateJoined);
                    command.Parameters.AddWithValue("@LastReviewed", lastReviewed);
                    command.Parameters.AddWithValue("@LastDemoDate", lastDemoDate);
                    command.Parameters.AddWithValue("@EstablishedDate", establishedDate);
                    command.Parameters.AddWithValue("@CompanyWebsite", "%" + companyWebsite + "%");
                    command.Parameters.AddWithValue("@NumberOfEmployees", "%" + numberOfEmployees + "%");

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
                Console.WriteLine("Error in SearchInDatabase: " + ex.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("SearchInDatabase method finished...");
            }
        }

    }
}
