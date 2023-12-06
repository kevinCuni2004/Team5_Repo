using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;


//taya is currently working on this class, please do not change anything here
namespace Citisoft
{
    public class Search
    {
        private DBConnection dbConnection;

        public Search()
        {
            dbConnection = DBConnection.getInstance();

        }

        public SqlDataReader SearchVendors(string searchText)
        {
            string[] keywords = searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sqlQuery = new StringBuilder("SELECT * FROM [Companies] WHERE");
            for(int i = 0; i < keywords.Length; i++)
            {
                sqlQuery.Append($"[company_name] LIKE @SearchText{i} OR " +
                    $"[company_website] LIKE @SearchText{i} OR " +
                    $"EXISTS (SELECT 1 FROM [Products] WHERE [Companies].[company_id] = [Products].[company_id] AND " +
                    $"([description] LIKE @SearchText{i} OR [cloud] LIKE @SearchText{i} OR [software_name] LIKE @SearchText{i}))");

                if (i < keywords.Length - 1)
                {
                    sqlQuery.Append(" AND ");
                }


            }
           
            SqlCommand command = new SqlCommand(sqlQuery.ToString());

            for (int i =0; i <keywords.Length; i++)
            {
                command.Parameters.AddWithValue($"@SearchText{i}", $"%{keywords[i]}%");
            }
           
            return dbConnection.ExcecuteReader(command);
        }

         private DataTable GetDataFromDatabase(string query, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
                return null;
            }
        }

    }

}

