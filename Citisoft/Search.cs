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

        public DataTable SearchCompanies(string companyName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
                {
                    string searchQuery = "SELECT * FROM [Companies] WHERE [company_name] LIKE @CompanyName";

                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        companyName = "%" + companyName + "%";
                        command.Parameters.AddWithValue("@CompanyName", companyName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable resultsTable = new DataTable();
                            resultsTable.Load(reader);
                            return resultsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in SearchCompanies: " + ex.Message);
                return null;
            }
        }
    }

}

