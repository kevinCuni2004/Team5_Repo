using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Citisoft
{

    public class SignUp
    {
        private DBConnection dbConnection;
        public SignUp()
        {
            dbConnection = DBConnection.getInstance();
        }

        // user's registration proccess
        public (string message, Profile profile) RegisterUser(string email, string password)
        {
            try
            {
                // validation of the email
                if (!email.EndsWith("@citisoft.co.uk"))
                {
                    throw new ArgumentException("Email must end with company's requirements. Email should end with '@citisoft.co.uk'");
                }

                if (!IsPasswordValid(password))
                {
                    throw new ArgumentException("Password should be at least 8 charactes long and include capital letters, numbers and special characters");
                }


                if (!IsEmailAvailable(email))
                {

                    throw new ArgumentException("Account already exists");
                }

                // encryption of the password
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // inserting hashed password in the database
                string sqlQuery = $"INSERT INTO Profile ([e-mail], [password]) VALUES ('{email}', '{hashedPassword}')";
                dbConnection.saveToDB(sqlQuery);


                // creating the profile of the user
                return ("Success", new Profile
                {
                    Email = email,
                    Password = hashedPassword
                });

            }
            catch (Exception ex)
            {
               return (ex.Message, null);
            }
        }


        // chekin the existence of the email in yhe database
        private bool IsEmailAvailable(string email)
        {
            string query = $"SELECT COUNT (*) FROM Profile WHERE [e-mail] = '{email}'";
            int count = Convert.ToInt32(dbConnection.ExecuteScalar(query));
            return count == 0;
        }


        // validation of the password
        private bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[A-Z])(?=.*[a^zA-Z\d]).{8,25}$");

        }
    }
}
