using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    //Ivan
    public class Access
    {
        private DBConnection dbConnection;
        public Access()
        {
            dbConnection = DBConnection.getInstance();
        }
        public DataTable LoadData()
        {
            string query = "SELECT [profile_id], [access], [first_name], [last_name] FROM Profile";
            DataSet dataSet = dbConnection.getDataSet(query);
            return dataSet.Tables[0];
        }

        public void UpdateAccess(int profileId, int access, string firstName, string lastName)
        {
            string query = "UPDATE Profile SET [access] = @access, [first_name] = @name, [last_name] = @surname WHERE [profile_id] = @id";
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@access", access);
                    command.Parameters.AddWithValue("@name", firstName);
                    command.Parameters.AddWithValue("@surname", lastName);
                    command.Parameters.AddWithValue("@id", profileId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
