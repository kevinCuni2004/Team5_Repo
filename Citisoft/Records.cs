using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Citisoft
{
    public class Records
    {
        private DBConnection dbConnection;
        private Dictionary<int, object> originalValues = new Dictionary<int, object>();
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModidiedNew);
        }
        public Records()
        {
            dbConnection = DBConnection.getInstance();
        }
        private void DisplayRecords(DataGridView dgw)
        {

            DBConnection dbConnection = DBConnection.getInstance();

            string query = "SELECT * FROM Products" + "SELECT * FROM Comapanies" + "SELECT * FROM Software_type";


            SqlCommand command = new SqlCommand(query, dbConnection.getDBConnection());

            try
            {

                dbConnection.openDBConnection();


                using (SqlDataReader reader = dbConnection.ExcecuteReader(command))
                {
                    while (reader.Read())
                    {
                        ReadSingleRow(dgw, reader);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
            }
        }
        private void InsertRecord(DataGridViewRow row)
        {
            DBConnection dbConnection = DBConnection.getInstance();
            string query = "INSERT INTO Profile (product_id, description, cloud, software_name, software_type, date_joined, last_reviewed_date, last_demo_date, established_date, internal_professional_services, company_website, no_of_employees) VALUES (@product_id, @description, @cloud, @software_name, @software_type, @date_joined, @last_reviewed_date, @last_demo_date, @established_date, @internal_professional_services, @company_website, @no_of_employees);";
            using (SqlCommand command = new SqlCommand(query, dbConnection.getDBConnection()))
            {
                try
                {
                    dbConnection.openDBConnection();
                    int productIdValue = Convert.ToInt32(row.Cells["product_id"].Value);
                    string descriptionValue = Convert.ToString(row.Cells["description"].Value);
                    string cloudValue = Convert.ToString(row.Cells["cloud"].Value);
                    string softwarenameValue = Convert.ToString(row.Cells["software_name"].Value);
                    string softwaretypeValue = Convert.ToString(row.Cells["sowtware_type"].Value);
                    DateTime datejoinedValue = Convert.ToDateTime(row.Cells["date_joined"].Value);
                    DateTime lastrevieweddateValue = Convert.ToDateTime(row.Cells["last_reviewed_date"].Value);
                    DateTime lastdemodateValue = Convert.ToDateTime(row.Cells["last_demo_date"].Value);
                    DateTime establisheddateValue = Convert.ToDateTime(row.Cells["established_date"].Value);
                    string internalprofessionalservicesValue = Convert.ToString(row.Cells["internal_professional_services"].Value);
                    string companywebsiteValue = Convert.ToString(row.Cells["company_website"].Value);
                    string noofemployeesValue = Convert.ToString(row.Cells["no_of_employees"].Value);


                    command.Parameters.AddWithValue("@product_id", productIdValue);
                    command.Parameters.AddWithValue("@description", descriptionValue);
                    command.Parameters.AddWithValue("@cloud", cloudValue);
                    command.Parameters.AddWithValue("@software_name", softwarenameValue);
                    command.Parameters.AddWithValue("@software_type", softwaretypeValue);
                    command.Parameters.AddWithValue("@date_joined", datejoinedValue);
                    command.Parameters.AddWithValue("@last_reviewed_date", lastrevieweddateValue);
                    command.Parameters.AddWithValue("@last_demo_date", lastdemodateValue);
                    command.Parameters.AddWithValue("@established_date", establisheddateValue);
                    command.Parameters.AddWithValue("@internal_professional_services", internalprofessionalservicesValue);
                    command.Parameters.AddWithValue("@company_website", companywebsiteValue);
                    command.Parameters.AddWithValue("@no_of_employees", noofemployeesValue);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Insert successfil");
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteRecord(DataGridViewRow row)
        {
            DBConnection dbConnection = DBConnection.getInstance();
            string query = "DELETE FROM Profile WHERE product_id = @product_id AND description = @description AND cloud = @cloud AND software_name = @software_name AND software_type = @software_type AND date_joined = @date_joined AND last_reviewed_date = @last_reviewed_date AND last_demo_date = @last_demo_date AND established_date = @established_date AND internal_professional_services = @internal_professional_services  AND company_website = @company_website AND no_of_employees = @no_of_employees ;";

            using (SqlCommand command = new SqlCommand(query, dbConnection.getDBConnection()))
            {
                try
                {
                    dbConnection.openDBConnection();

                    // Получение оригинальных значений, если они не сохранены
                    if (!originalValues.ContainsKey(row.Index))
                    {
                        originalValues[row.Index] = new
                        {
                            ProductId = Convert.ToString(row.Cells["product_id"].Value),
                            Description = Convert.ToString(row.Cells["description"].Value),
                            Cloud = Convert.ToString(row.Cells["cloud"].Value),
                            SoftwareName = Convert.ToString(row.Cells["software_name"].Value),
                            SoftwareType = Convert.ToString(row.Cells["software_type"].Value),
                            DateJoined = Convert.ToDateTime(row.Cells["date_joined"].Value),
                            LastReviewedDate = Convert.ToDateTime(row.Cells["last_reviewed_date"].Value),
                            LastDemoDate = Convert.ToDateTime(row.Cells["last_demo_date"].Value),
                            EstablishedDate = Convert.ToDateTime(row.Cells["established_date"].Value),
                            InternalProfessionalSevices = Convert.ToString(row.Cells["internal_professional_services"].Value),
                            CompanyWebsite = Convert.ToString(row.Cells["company_website"].Value),
                            NoOfEmployees = Convert.ToInt64(row.Cells["no_of_employees"].Value)





                        };
                    }


                    command.Parameters.AddWithValue("@product_id", ((dynamic)originalValues[row.Index]).ProductId);
                    command.Parameters.AddWithValue("@description", ((dynamic)originalValues[row.Index]).Description);
                    command.Parameters.AddWithValue("@cloud", ((dynamic)originalValues[row.Index]).Cloud);
                    command.Parameters.AddWithValue("@software_name", ((dynamic)originalValues[row.Index]).SoftwareName);
                    command.Parameters.AddWithValue("@software_type", ((dynamic)originalValues[row.Index]).SoftwareType);
                    command.Parameters.AddWithValue("@date_joined", ((dynamic)originalValues[row.Index]).DateJoined);
                    command.Parameters.AddWithValue("@last_reviewed_date", ((dynamic)originalValues[row.Index]).LastReviewedDate);
                    command.Parameters.AddWithValue("@last_demo_date", ((dynamic)originalValues[row.Index]).LastDemoDate);
                    command.Parameters.AddWithValue("@established_date", ((dynamic)originalValues[row.Index]).EstablishedDate);
                    command.Parameters.AddWithValue("@internal_professional_services", ((dynamic)originalValues[row.Index]).InternalProfessionalSevices);
                    command.Parameters.AddWithValue("@company_website", ((dynamic)originalValues[row.Index]).CompanyWebsite);
                    command.Parameters.AddWithValue("@no_of_employees", ((dynamic)originalValues[row.Index]).SoftwareType);



                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete successful!");
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                }
            }
        }
        private void UpdateRecord(DataGridViewRow row)
        {
            DBConnection dbConnection = DBConnection.getInstance();
            string query = "UPDATE  Profile SET product_id = @product_id AND description = @description AND cloud = @cloud AND software_name = @software_name AND software_type = @software_type AND date_joined = @date_joined AND last_reviewed_date = @last_reviewed_date AND last_demo_date = @last_demo_date AND established_date = @established_date AND internal_professional_services = @internal_professional_services  AND company_website = @company_website AND no_of_employees = @no_of_employees;";

            using (SqlCommand command = new SqlCommand(query, dbConnection.getDBConnection()))
            {
                try
                {
                    dbConnection.openDBConnection();
                    int productIdValue = Convert.ToInt32(row.Cells["product_id"].Value);
                    string descriptionValue = Convert.ToString(row.Cells["description"].Value);
                    string cloudValue = Convert.ToString(row.Cells["cloud"].Value);
                    string softwarenameValue = Convert.ToString(row.Cells["software_name"].Value);
                    string softwaretypeValue = Convert.ToString(row.Cells["sowtware_type"].Value);
                    DateTime datejoinedValue = Convert.ToDateTime(row.Cells["date_joined"].Value);
                    DateTime lastrevieweddateValue = Convert.ToDateTime(row.Cells["last_reviewed_date"].Value);
                    DateTime lastdemodateValue = Convert.ToDateTime(row.Cells["last_demo_date"].Value);
                    DateTime establisheddateValue = Convert.ToDateTime(row.Cells["established_date"].Value);
                    string internalprofessionalservicesValue = Convert.ToString(row.Cells["internal_professional_services"].Value);
                    string companywebsiteValue = Convert.ToString(row.Cells["company_website"].Value);
                    string noofemployeesValue = Convert.ToString(row.Cells["no_of_employees"].Value);

                    command.Parameters.AddWithValue("@product_id", productIdValue);
                    command.Parameters.AddWithValue("@description", descriptionValue);
                    command.Parameters.AddWithValue("@cloud", cloudValue);
                    command.Parameters.AddWithValue("@software_name", softwarenameValue);
                    command.Parameters.AddWithValue("@software_type", softwaretypeValue);
                    command.Parameters.AddWithValue("@date_joined", datejoinedValue);
                    command.Parameters.AddWithValue("@last_reviewed_date", lastrevieweddateValue);
                    command.Parameters.AddWithValue("@last_demo_date", lastdemodateValue);
                    command.Parameters.AddWithValue("@established_date", establisheddateValue);
                    command.Parameters.AddWithValue("@internal_professional_services", internalprofessionalservicesValue);
                    command.Parameters.AddWithValue("@company_website", companywebsiteValue);
                    command.Parameters.AddWithValue("@no_of_employees", noofemployeesValue);



                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                }
            }
        }
    }
}
