using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    public class Access
    {
        //private Profile User;
        private DBConnection dbConnection;
        public Access()
        {
            dbConnection = DBConnection.getInstance();

        }
        public DataTable LoadData()
        {
            string query = "SELECT profile_id, access, name, surname FROM Profile";
            DataSet dataSet = dbConnection.getDataSet(query);
            return dataSet.Tables[0];
        }

        public void UpdateAccess(int profileId, int access, string firstName, string lastName)
        {
            string query = "UPDATE Profile SET access = @access, FirstName = @name, Surname = @surname WHERE Id = @id";
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
        //public Profile loadThreeValues(string email)
        //{
            //Profile User = new Profile();
            //string query = "SELECT * FROM [Profile] WHERE [e-mail]=@email;";
            //User.Email = email;
            //dBConnection = DBConnection.getInstance();
            //SqlCommand command = new SqlCommand(query);
            //command.Parameters.AddWithValue("@email", email);
            //User.Add(new Profile { Id = 1, Access = 1, FirstName = "Jhon", LastName = "dskfpsd"});
            //return User;
       // }
    }
}
