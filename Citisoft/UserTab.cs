using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string query = "SELECT * FROM [Profile] WHERE [e-mail]=@email";
            
            dBConnection = DBConnection.getInstance();
            DataSet dataSet = dBConnection.getDataSet(query);
            user.Id = Convert.ToInt32(dataSet.Tables["Profile"].Columns["profile_id"]);
            if (dataSet.Tables["Profile"].Columns["admin_id"] != null)
            {
                user.AdminID = Convert.ToInt32(dataSet.Tables["Profile"].Columns["admin_id"]);
            } else { user.AdminID = 0; }
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
            } else { user.Details = "No Details"; }
            
            return user;
        }
    }
}
