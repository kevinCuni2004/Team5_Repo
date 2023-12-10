using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private static UserTab _instance;


        public UserTab() { }

        public UserTab(Profile User)
        {
            this.user = User;
        }

        public static UserTab getInstance()
        {
            if (_instance == null)
            {
                return _instance = new UserTab();
            }
            return _instance;
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

        public bool checkPassword(string password)
        {
            if (!Regex.IsMatch(password, @"^(?=.*\d)(?=.*[A-Z])(?=.*[a^zA-Z\d]).{8,25}$")) return false;
            return true;
        }

        public string updatePassword(string password, string email)
        {
            string hashedPassword;
            try
            {
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            }
            catch
            {
                return "Failed Encrypition";
            }

            try
            {
                dBConnection = DBConnection.getInstance();
                dBConnection.ExecutenNonQuery("Profile", "password", hashedPassword, email);
            }
            catch
            {
                return "Failed database connection";
            }
            return hashedPassword;
        }
    }
}
