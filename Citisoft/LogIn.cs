using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Citisoft
{
    public class LogIn
    {
        private DBConnection dBConnection;

        public LogIn()
        {
            dBConnection = DBConnection.getInstance();
        }

        // user authentication
        public (string message, Profile userProfile) AuthenticateUser(string email, string password)
        {
            try
            {
                // checks the existance of the e-mail
                
                if (!UserExists(email))
                {
                    throw new InvalidOperationException("User does not exist");
                }

                //checking if password and email are matching and written correctly
                if(!IsValidCredentials(email, password))
                {
                    throw new InvalidOperationException("Invalid email or password");
                }

                //successful case
                //entering profile 
                Profile user = LoadUserProfile(email);

                return ("Success", user);
            }

            catch (Exception ex)
            {
                return (ex.Message, null);
            }
        }


        //method to find email in database
        private bool UserExists(string email)
        {
            string query = $"SELECT COUNT(*) FROM Profile WHERE [e-mail] = '{email}'";
            int count = Convert.ToInt32(dBConnection.ExecuteScalar(query));
            return count > 0;
        }

        //method to check if email and password match
        private bool IsValidCredentials(string email,string password)
        {
            string query = $"SELECT [password] FROM Profile WHERE [e-mail] = '{email}'";
           
            // decryption of the password
            string hashedPassword = dBConnection.ExecuteScalar(query)?.ToString();
            if (hashedPassword != null && !BCrypt.Net.BCrypt.Verify(password, hashedPassword))
            {
                string newHashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                return true;
            }

            return hashedPassword != null;
            
            //check if it will work without it
            //int count = Convert.ToInt32(dBConnection.ExecuteScalar(query));
            //return count > 0;

        }

        // entering the profile 
        private Profile LoadUserProfile (string email)
        {
            return new Profile();
        }
    }
}
