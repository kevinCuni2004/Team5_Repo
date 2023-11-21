using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft
{

    public class SignUp
    {
        private DBConnection dbConnection;
        public SignUp()
        {
            dbConnection = DBConnection.getInstance();
        }

        public (string message, Profile profile) RegisterUser(string email, string password)
        {
            try
            {
                if (!email.EndsWith("@citisoft.co.uk"))
                {
                    throw new ArgumentException("Email must end with company's requirements");
                }

                if (!IsPasswordValid(password))
                {
                    throw new ArgumentException("Password must meet company's requirements");
                }

                if (!IsEmailAvailable(email))
                {

                    throw new ArgumentException("Account already exists");
                }

                string sqlQuery = $"INSERT INTO Profile ([e-mail], [password]) VALUES ('{email}', '{password}')";
                dbConnection.saveToDB(sqlQuery);

                return ("Success", new Profile
                {
                    Email = email,
                    Password = password
                });

            }
            catch (Exception ex)
            {
                return (ex.Message, null);
            }
        }


        private bool IsEmailAvailable(string email)
        {
            string query = $"SELECT COUNT (*) FROM Profile WHERE [e-mail] = '{email}'";
            int count = Convert.ToInt32(dbConnection.ExecuteScalar(query));
            return count == 0;
        }

        private bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[A-Z])(?=.*[a^zA-Z\d]).{8,25}$");

        }
    }
}
