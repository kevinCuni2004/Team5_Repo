using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Citisoft
{
    public class Records
    {
        private DBConnection dbConnection;
        private Dictionary<int, object> originalValues = new Dictionary<int, object>();
        
        public Records()
        {
            dbConnection = DBConnection.getInstance();
        }
        public CompanyAndProducts loadValues(string name)
        {
            CompanyAndProducts RecordCandP = new CompanyAndProducts(name);
            string query = "SELECT * FROM [Companies] WHERE [company_name]=@companyName;";
            //RecordCandP.CompanyName = companyName;
           // dBConnection = DBConnection.getInstance();
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@companyName", name);
            //User.Add(new Profile { Id = 1, Access = 1, FirstName = "Jhon", LastName = "dskfpsd"});
            return RecordCandP;
        }
    }
}