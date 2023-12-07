using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    public class Access
    {
        private Profile User;
        private DBConnection dBConnection;
        public Access()
        {
            dBConnection = DBConnection.getInstance();

        }
        public Profile loadThreeValues(string email)
        {
            Profile User = new Profile();
            string query = "SELECT * FROM [Profile] WHERE [e-mail]=@email;";
            User.Email = email;
            dBConnection = DBConnection.getInstance();
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@email", email);
            //User.Add(new Profile { Id = 1, Access = 1, FirstName = "Jhon", LastName = "dskfpsd"});
            return User;
        }
    }
}
