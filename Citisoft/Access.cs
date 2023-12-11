//libraries
using System;
using System.Data;
using System.Data.SqlClient;

namespace Citisoft
{
    //ivan
    public class Access
    {
        //variables
        private DBConnection dbConnection;
        public Access()
        {
            //exemplar for db connection from DBConnection class
            dbConnection = DBConnection.getInstance();
        }

        internal DBConnection DBConnection
        {
            get => default;
            set
            {
            }
        }

        //method for do Select Query for getting data from Profile table
        public DataTable LoadData()
        {
            string query = "SELECT [profile_id], [access], [first_name], [last_name] FROM Profile";
            DataSet dataSet = dbConnection.getDataSet(query);
            return dataSet.Tables[0];
        }
        //method that update data from Profile Table(using Update Query)
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
