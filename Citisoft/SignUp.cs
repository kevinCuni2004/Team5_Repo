using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

        public string RegisterUser(string email, string password)
        {
            if (!email.EndsWith("@citisoft.co.uk"))
            {
                Console.WriteLine("Email must end with companies requierments");
                return "Email must end with company's requirements";
            }

            if (!IsPasswordValid(password))
            {
                Console.WriteLine("Password must end with companies requierments");
                return "Password must meet company's requirements";
            }

            if (!IsEmailAvailable(email))
            {
                Console.WriteLine("Email  end with companies requierments");
                return "Account already exists";
            }

            string sqlQuery = $"INSERT INTO Profile ([e-mail], [password]) VALUES ('{email}', '{password}')";
            dbConnection.saveToDB(sqlQuery);
            
            return "Success";
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
