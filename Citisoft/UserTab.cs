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

        public Profile loadProfile(string email)
        {
            user = new Profile();
            string query = "SELECT * FROM [Profile] WHERE [e-mail]=@email;";
            user.Email = email;
            dBConnection = DBConnection.getInstance();
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@email", email);
            using (SqlDataReader reader = dBConnection.ExcecuteReader(command))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(reader.GetOrdinal("profile_id"));
                        if (!reader.IsDBNull(reader.GetOrdinal("admin_id")))
                        {
                            user.AdminID = reader.GetInt32(reader.GetOrdinal("admin_id"));
                        }
                        else user.AdminID = 0;
                        user.Username = reader.GetString(reader.GetOrdinal("username"));
                        user.FirstName = reader.GetString(reader.GetOrdinal("first_name"));
                        user.LastName = reader.GetString(reader.GetOrdinal("last_name"));
                        user.DateofBirth = reader.GetDateTime(reader.GetOrdinal("date_of_birth"));
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
            return user;
        }
    }
}
