using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    internal class LogIn
    {
        private DBConnection dBConnection;

        public LogIn()
        {
            dBConnection = DBConnection.getInstance();
        }

        public (string message, Profile userProfile) AuthenticateUser(string email, string password)
        {
            try
            {
                if (!UserExists(email))
                {
                    throw new InvalidOperationException("User does not exist");
                }

                if(!IsValidCredentials(email, password))
                {
                    throw new InvalidOperationException("Invalid email or password");
                }

                Profile user = LoadUserProfile(email);

                return ("Success", user);
            }

            catch (Exception ex)
            {
                return (ex.Message, null);
            }
        }

        private bool UserExists(string email)
        {
            string query = $"SELECT COUNT(*) FROMProfile WHERE [e-mail] = '{email}'";
            int count = Convert.ToInt32(dBConnection.ExecuteScalar(query));
            return count > 0;
        }

        private bool IsValidCredentials(string email,string password)
        {
            string query = $"SELECT COUNT(*) FROMProfile WHERE [e-mail] = '{email}' AND [password] = '{password}'";
            int count = Convert.ToInt32(dBConnection.ExecuteScalar(query));
            return count > 0;

        }

        private Profile LoadUserProfile (string email)
        {
            return new Profile();
        }
    }
}
