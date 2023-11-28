using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Citisoft
{
    public partial class AccessForm : Form
    {
        private DBConnection dBConnection;
        private int profileColumnIndex;
        private int accessColumnIndex;
        private string nameColumnIndex;
        private string surnameColumnIndex;
        private Dictionary<int, object> originalValues = new Dictionary<int, object>();

        public AccessForm()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataAccess.Columns.Add("profile_id", "Id");
            dataAccess.Columns.Add("access", "Status");
            dataAccess.Columns.Add("name", "Name");
            dataAccess.Columns.Add("surname", "Surname");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord access)
        {
            dgw.Rows.Add(access.GetInt32(0), access.GetInt32(1), access.GetString(2), access.GetString(3), RowState.ModidiedNew);
        }
        private void DisplayAccess(DataGridView dgw)
        {
            //--We don't have objects in attributes so it wont work--//
            DBConnection dbConnection = DBConnection.getInstance();
            string query = "SELECT * FROM PROFILE";
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
            //--go to usertab form--//

            UserTabForm usertabForm = new UserTabForm();
            usertabForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //--go to admin home page form--//
            //--we don't have now so it won't work--//

            //AdminHomePage adminhomepage = new AdminHomePage();
            //adminhomepage.Show();
            //this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //--Edit button disapppears. Cancel/Confirm buttons appears--//
            editButton.Visible = false;
            cancelButton.Visible = true;
            confirmButton.Visible = true;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            editButton.Visible = true;
            if (dataAccess.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataAccess.SelectedRows[0];
                CancelEdit(selectedRow);
            }
        }
        private void CancelEdit(DataGridViewRow selectedRow)
        {
            if (originalValues.ContainsKey(selectedRow.Index))
            {
                selectedRow.Cells[profileColumnIndex].Value = originalValues[selectedRow.Index];
                originalValues.Remove(selectedRow.Index);
            }
        }
        private void EditAccess(DataGridViewRow selectedRow)
        {
            dataAccess.ReadOnly = false;
            if (!originalValues.ContainsKey(selectedRow.Index))
            {
                profileColumnIndex = dataAccess.Columns["Id"].Index;
                originalValues[selectedRow.Index] = selectedRow.Cells[profileColumnIndex].Value;
                //descriptionColumnIndex = dataRecords.Columns["Description"].Index;
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = true;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            foreach (DataGridViewRow row in dataAccess.Rows)
            {
                RowState rowState = (RowState)(row.Tag ?? RowState.Existed);

                switch (rowState)
                {
                    case RowState.New:
                        //make a realization for setting new element
                        //InsertAccess(row);
                        break;

                    case RowState.Modified:
                    case RowState.Edit:
                        //make a realization for updating in db
                        //UpdateAccess(row);
                        break;

                    case RowState.Deleted:
                        //make a realization for deleting in rows
                        //DeleteAccess(row);
                        break;


                    default:
                        break;
                }
            }
        }

        private void dataAccess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataAccess.ReadOnly = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataAccess.Rows[e.RowIndex];
                EditAccess(selectedRow);
            }
        }

        private void AccessForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            DisplayAccess(dataAccess);
        }
    }
}
