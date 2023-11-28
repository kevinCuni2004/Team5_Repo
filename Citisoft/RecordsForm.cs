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
        public RecordsForm()
        {
            InitializeComponent();
            cancelButton.Click += cancelButton_Click;
        }
        private void CreateColumns()
        {
            dataRecords.Columns.Add("product_id", "Id");
            dataRecords.Columns.Add("description", "Description");
            dataRecords.Columns.Add("cloud", "Cloud");
            dataRecords.Columns.Add("software_name", "Software name");
            dataRecords.Columns.Add("sowtware_type", "Sowtware type");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModidiedNew);
        }
        private void DisplayRecords(DataGridView dgw)
        {

            DBConnection dbConnection = DBConnection.getInstance();

            string query = "SELECT * FROM Products";


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
            //UserTabForm usertabForm = new UserTabForm();
            //usertabForm.Show();
            //this.Hide();
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
                        //InsertRecord(row);
                        break;

                    case RowState.Modified:
                    case RowState.Edit:
                        //make a realization for updating in db
                        //UpdateRecord(row);
                        break;

                    case RowState.Deleted:
                        //make a realization for deleting in rows
                        //DeleteRecord(row);
                        break;


                    default:
                        break;
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
    }
}
