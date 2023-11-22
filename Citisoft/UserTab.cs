using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Citisoft
{
    public class UserTab
    {
        private Profile user;
        private DBConnection dBConnection;
        private UserTabForm userTabForm;
       

        public UserTab () { }

        public UserTab(UserTabForm userTabForm)
        {
            
        }

        public Profile loadProfile(string email) {
            user = new Profile();
            //string query = "SELECT * FROM [Profile] WHERE [e-mail]='" + email + "';";
            string query = "SELECT * FROM [Profile] WHERE [e-mail]=@email;";
            user.Email = email;
            dBConnection = DBConnection.getInstance();
            string connStr = Properties.Settings.Default.DBConnectionString;
            SqlConnection connToDB = new SqlConnection(connStr);
            using (SqlCommand command = new SqlCommand(query, connToDB))
            {
                connToDB.Open();
                command.Parameters.AddWithValue("@email", email);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user.Id = reader.GetInt32(reader.GetOrdinal("profile_id"));
                            if (!reader.IsDBNull(reader.GetOrdinal("admin_id")))
                            {
                                user.AdminID = reader.GetInt32(reader.GetOrdinal("admin_id"));
                            } else user.AdminID = 0;
                            user.Username = reader.GetString(reader.GetOrdinal("username"));
                            user.FirstName = reader.GetString(reader.GetOrdinal("first_name"));
                            user.LastName = reader.GetString(reader.GetOrdinal("last_name"));
                            user.Age = reader.GetInt32(reader.GetOrdinal("age"));
                            user.Email = email;
                            user.Password = reader.GetString(reader.GetOrdinal("password"));
                            user.Access = reader.GetInt32(reader.GetOrdinal("access"));
                            if (!reader.IsDBNull(reader.GetOrdinal("details")))
                            {
                                user.Details = reader.GetString(reader.GetOrdinal("admin_id"));
                            }
                            else user.Details = "No Details Available";
                        }
                    }
                    else
                    {
                        Console.WriteLine("No matching records found.");
                    }
                }
            }
                /*DataSet dataSet = dBConnection.getDataSet(query);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    //user.Id = Convert.ToInt32(dataSet.Tables["Profile"].Columns["profile_id"]);
                    user.Id = Convert.ToInt32(dataSet.Tables["Profile"].Rows[0]["profile_id"]);
                    if (dataSet.Tables["Profile"].Columns["admin_id"] != null)
                    {
                        user.AdminID = Convert.ToInt32(dataSet.Tables["Profile"].Columns["admin_id"]);
                    }
                    else { user.AdminID = 0; }
                    user.Username = Convert.ToString(dataSet.Tables["Profile"].Columns["username"]);
                    user.FirstName = Convert.ToString(dataSet.Tables["Profile"].Columns["first_name"]);
                    user.LastName = Convert.ToString(dataSet.Tables["Profile"].Columns["last_name"]);
                    user.Age = Convert.ToInt32(dataSet.Tables["Profile"].Columns["age"]);
                    user.Email = email;
                    user.Password = Convert.ToString(dataSet.Tables["Profile"].Columns["password"]);
                    user.Access = Convert.ToInt32(dataSet.Tables["Profile"].Columns["access"]);
                    if (dataSet.Tables["Profile"].Columns["details"] != null)
                    {
                        user.Details = Convert.ToString(dataSet.Tables["Profile"].Columns["details"]);
                    }
                    else { user.Details = "No Details"; }
                } else
                {
                    Exception ex = new Exception();
                    throw ex;
                }*/
            return user;
        }
    }
}
