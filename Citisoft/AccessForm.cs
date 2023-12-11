//libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class AccessForm : Form
    {   
        //Variables the code use
        private DBConnection dbConnection;
        private DataTable originalData;
        private Dictionary<int, Tuple<int, string, string>> originalValues = new Dictionary<int, Tuple<int, string, string>>();
        public AccessForm()
        {
            dbConnection = DBConnection.getInstance();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public Access Access
        {
            get => default;
            set
            {
            }
        }

        //method of creating columns
        private void ColumnsCreate()
        {
            dataAccess.Columns.Add("profile_id", "Id");
            dataAccess.Columns.Add("access", "Status");
            dataAccess.Columns.Add("name", "First Name");
            dataAccess.Columns.Add("surname", "Last Name");
        }
        //add rows
        private void ReadSingleRow(DataGridView dataAccess, DataRow row)
        {
            dataAccess.Rows.Add(
            row.Field<int>(0),
            row.Field<int>(1),
            row.Field<string>(2),
            row.Field<string>(3)
            );
        }
        //Set the old values from the db
        private void CancelChanges(DataGridView dataAccess, DataTable originalData)
        {
            dataAccess.Rows.Clear();
            foreach(DataRow row in originalData.Rows)
            {
                dataAccess.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }
        //Update data from db/call a messagebox
        private void UpdateAccess(DataGridView dataAccess)
        {
            foreach(DataGridViewRow row in dataAccess.Rows)
            {
                int profileId = Convert.ToInt32(row.Cells["profile_id"].Value);
                int access = Convert.ToInt32(row.Cells["access"].Value);
                string firstName = Convert.ToString(row.Cells["name"].Value);
                string lastName = Convert.ToString(row.Cells["surname"].Value);
                Access accessManager = new Access();
                accessManager.UpdateAccess(profileId, access, firstName, lastName);
            }
            MessageBox.Show("Data successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //By click go to usertab form
        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm();
            this.Hide();
            usertabForm.ShowDialog();
            this.Show();
        }
        //go back to admin home page form
        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHomePageForm adminhomepage = new AdminHomePageForm();
            this.Hide();
            adminhomepage.ShowDialog();
            this.Show();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            //Edit button disapppears. Cancel/Confirm buttons appears
            editButton.Visible = false;
            cancelButton.Visible = true;
            confirmButton.Visible = true;
            dataAccess.ReadOnly = false;
            dataAccess.EditMode = DataGridViewEditMode.EditOnEnter;
        }
        //Edit button appears. Cancel/Confirm buttons disapper
        private void cancelButton_Click(object sender, EventArgs e)
        {
            dataAccess.ReadOnly = true;
            dataAccess.EditMode = DataGridViewEditMode.EditProgrammatically;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            editButton.Visible = true;
            CancelChanges(dataAccess, originalData);
        }
        //The UpdateAccess() method from form is called and data in the table is updated, as is the data in the databas. 
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //edit button appears. Cancle and Confirm buttons disappears 
            editButton.Visible = true;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            dataAccess.ReadOnly = true;
            dataAccess.EditMode = DataGridViewEditMode.EditProgrammatically;
            //Also call MessageBox in case of success or error.
            try
            {
                UpdateAccess(dataAccess);
                MessageBox.Show("Data successfully saved o the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving data:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //empty methdot that does not do anything(Just an accident click)
        private void dataAccess_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //load columns and the data, fill datagridview and save data into variable
        private void AccessForm_Load(object sender, EventArgs e)
        {
            ColumnsCreate();
            DataTable data = new Access().LoadData();
            foreach(DataRow row in data.Rows)
            {
                ReadSingleRow(dataAccess, row);
            }
            originalData = data.Copy();
        }
    }
}
