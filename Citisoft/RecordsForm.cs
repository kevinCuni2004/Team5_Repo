using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.PeerToPeer;
using System.Drawing.Drawing2D;

namespace Citisoft
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        Deleted,
        ModidiedNew,
        Edit
    }
    
    public partial class RecordsForm : Form
    {
        private DBConnection dBConnection;
        private int productColumnIndex;
        private string descriptionColumnIndex;
        private string cloudColumnIndex;
        private string softwareNameColumnIndex;
        private string softwareTypeColumnIndex;
        private Dictionary<int, object> originalValues = new Dictionary<int, object>();
        private Records records;
        public RecordsForm()
        {
            InitializeComponent();
            cancelButton.Click += cancelButton_Click;
            records = new Records();
            //panel1.Paint += Panel1_Paint;
        }


        private void CreateColumns()
        {
            dataRecords.Columns.Add("product_id", "Id");
            dataRecords.Columns.Add("description", "Description");
            dataRecords.Columns.Add("cloud", "Cloud");
            dataRecords.Columns.Add("software_name", "Software name");
            dataRecords.Columns.Add("sowtware_type", "Sowtware type");
            dataRecords.Columns.Add("company_name", "Company name");
            dataRecords.Columns.Add("date_joined", "Founding date");
            dataRecords.Columns.Add("last_reviewed_date", "Last eviewed date");
            dataRecords.Columns.Add("last_demo_date", "Last demo date");
            dataRecords.Columns.Add("established_date", "Established date");
            dataRecords.Columns.Add("internal_professional_services", "Internal professional services ");
            dataRecords.Columns.Add("company_website", "Company website");
            dataRecords.Columns.Add("no_of_employees", "No of employees");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModidiedNew);
        }
        private void DisplayRecords(DataGridView dgw)
        {

            DBConnection dbConnection = DBConnection.getInstance();

            string query = "SELECT * FROM Products"  + "SELECT* FROM Comapanies" + "SELECT* FROM Software_type";


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

        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm();
            usertabForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //AdminHomePage adminhomepage = new AdminHomePage();
            //adminhomepage.Show();
            //this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            cancelButton.Visible = true;
            confirmButton.Visible = true;
        }

        private void dataRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataRecords.Rows[e.RowIndex];
                EditRecord(selectedRow);
            }
        }
        private void EditRecord(DataGridViewRow selectedRow)
        {
            if (!originalValues.ContainsKey(selectedRow.Index))
            {
                productColumnIndex = dataRecords.Columns["Id"].Index;  
                originalValues[selectedRow.Index] = selectedRow.Cells[productColumnIndex].Value;
                //descriptionColumnIndex = dataRecords.Columns["Description"].Index;
            }
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            DisplayRecords(dataRecords);
        }                                             

        private void confirmButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = true;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            foreach (DataGridViewRow row in dataRecords.Rows)
            {
                RowState rowState = (RowState)(row.Tag ?? RowState.Existed);

                switch (rowState)
                {
                    case RowState.New:
                        //make a realization for setting new element
                        InsertRecord(row);
                        break;

                    case RowState.Modified:
                    case RowState.Edit:
                        //make a realization for updating in db
                        UpdateRecord(row);
                        break;

                    case RowState.Deleted:
                        //make a realization for deleting in rows
                        DeleteRecord(row);
                        break;


                    default:
                        break;
                }
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
                        MessageBox.Show("Insert successful");
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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = true;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            if (dataRecords.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataRecords.SelectedRows[0];
                CancelEdit(selectedRow);
            }
        }
        private void CancelEdit(DataGridViewRow selectedRow)
        {
            if (originalValues.ContainsKey(selectedRow.Index))
            {
                selectedRow.Cells[productColumnIndex].Value = originalValues[selectedRow.Index];
                originalValues.Remove(selectedRow.Index);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            //LinearGradientBrush lgb = new LinearGradientBrush(panel1.ClientRectangle, Color.FromArgb(0,255,0,0), Color.FromArgb(0,0,0,255), 45);
            //ColorBlend blend = new ColorBlend();
            //blend.Colors = new Color[3] {Color.FromArgb(255,255,255,255), Color.FromArgb(0,0,255,0), Color.FromArgb(0,255,0,0)};
            //blend.Positions = new float[3] { 0f, 0.5f, 1f };
            //lgb.InterpolationColors = blend;
            //e.Graphics.FillRectangle(lgb, panel1.ClientRectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RecordsForm_Load_1(object sender, EventArgs e)
        {
            CreateColumns();
        }
    }
}
