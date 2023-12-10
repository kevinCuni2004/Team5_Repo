using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.PeerToPeer;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Citisoft
{
    public class UserTab
    {
        private Profile user;//Profile object to store user
        private DBConnection dBConnection; //DBConnection object to connect to database
        private static UserTab _instance; //instance of the class


        public UserTab() { }//empty constructor


        public static UserTab getInstance()
        {
            if (_instance == null)
            {
                return _instance = new UserTab();
            }
            return _instance;
        }//checks if the instance already exists, if not creates it

        public Profile loadProfile(string email)
            //load the Profile info
        {
            user = new Profile();//initialize object
            string query = "SELECT * FROM [Profile] WHERE [e-mail]=@email;";//create query
            user.Email = email;//assign value
            dBConnection = DBConnection.getInstance();//get instance of DBConnection
            SqlCommand command = new SqlCommand(query);//create command for the reader
            command.Parameters.AddWithValue("@email", email);//add parameter
            using (SqlDataReader reader = dBConnection.ExcecuteReader(command))//using a reader, from DBConnection
            {
                if (reader.HasRows) //check if it's null
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
                    //assign all values into their respective variables
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
            //check format of password
            return true;
        }

        public string updatePassword(string password, string email)
        {
            string hashedPassword;
            try
            {
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                //hash password
            }
            catch
            {
                return "Failed Encrypition";
                //if an error occurs, return this string
            }

            try
            {
                dBConnection = DBConnection.getInstance();
                dBConnection.ExecutenNonQuery("Profile", "password", hashedPassword, email);
                //execute update statement from DBConnection
            }
            catch
            {
                return "Failed database connection";
                //if an error occurs, return this string
            }
            return hashedPassword;
            //return the hashed password
        }

        public bool checkName(string name)
        {
            return Regex.IsMatch(name, "^[A-Z][a-zA-Z]*$");
            //check name format
        }

        public string updateName(string name, int Name, string email)
        {
            try
            {
                dBConnection = DBConnection.getInstance();
                if (Name == 1)
                    dBConnection.ExecutenNonQuery("Profile", "first_name", name, email);//update 1st name
                else if (Name == 2)
                    dBConnection.ExecutenNonQuery("Profile", "last_name", name, email);//update last(2nd) name
                else
                    return "Failed executing query";
                //return this string if error occurred
            }
            catch
            {
                return "Failed database connection";
                //return this string if error occurred
            }
            return name;
            //return name if all goes well
        }

        public string updateDetails(string details, string email) {
            try
            {
                dBConnection = DBConnection.getInstance();
                dBConnection.ExecutenNonQuery("Profile", "details", details, email);//update details in database
            }
            catch
            {
                return "Failed database connection";
                //return this if error occurred
            }
            return details;
            //return details if it all goes well
        }

        public string updateUsername(string username, string email)
        {
            try
            {
                dBConnection = DBConnection.getInstance();
                dBConnection.ExecutenNonQuery("Profile", "username", username, email);
                //update username in database
            }
            catch
            {
                return "Failed database connection";
                //return this if error occurred
            }
            return username;
        }

        public DateTime updateDOB(DateTime dt, string email)
        {
            try
            {
                dBConnection = DBConnection.getInstance();
                dBConnection.ExecutenNonQuery("Profile", "date_of_birth", dt.ToShortDateString(), email);
                //update date of birth in database
            }
            catch
            {
                return new DateTime(1800, 1, 1);//return this date if error occurred
            }
            return dt;
            //return the updated date if all went well
        }
    }
}
