using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


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

        public DataTable SearchInDatabase(string keywords)
        {
            try
            {
                string sqlQuery = "SELECT * FROM Companies WHERE";
                DataTable schemaTable = dbConnection.getDBConnection().GetSchema("Columns", new[] { null, null, "Companies", null });

                List<string> columnNames = new List<string>();
                foreach (DataRow row in schemaTable.Rows)
                {
                    columnNames.Add(row["company_id"].ToString());
                }
                for (int i = 0; i < columnNames.Count; i++)
                {
                    sqlQuery += $"{columnNames[i]} LIKE @Keywords";
                    if (i < columnNames.Count - 1)
                    {
                        sqlQuery += " OR ";
                    }
                }
                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection.getDBConnection()))
                {
                    command.Parameters.AddWithValue("@keywords", "%" + keywords + "%");
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Search" + ex.Message);
                return null;
            }
        }
    }
}
