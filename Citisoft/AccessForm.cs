﻿using System;
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
        private DBConnection dbConnection;
        private DataTable originalData;

        public AccessForm()
        {
            dbConnection = DBConnection.getInstance();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataAccess.Columns.Add("profile_id", "Id");
            dataAccess.Columns.Add("access", "Status");
            dataAccess.Columns.Add("name", "First Name");
            dataAccess.Columns.Add("surname", "Last Name");
        }
        private void ReadSingleRow(DataGridView dataAccess, DataRow row)
        {
            dataAccess.Rows.Add(
                row.Field<int>(0),
                row.Field<int>(1),
                row.Field<string>(2),
                row.Field<string>(3)
                );
        }
        private void CancelChanges(DataGridView dataAccess, DataTable originalData)
        {
            dataAccess.Rows.Clear();
            foreach(DataRow row in originalData.Rows)
            {
                dataAccess.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }
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

            AdminHomePageForm adminhomepage = new AdminHomePageForm();
            adminhomepage.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //--Edit button disapppears. Cancel/Confirm buttons appears--//
            editButton.Visible = false;
            cancelButton.Visible = true;
            confirmButton.Visible = true;

            dataAccess.ReadOnly = false;
            dataAccess.EditMode = DataGridViewEditMode.EditOnEnter;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {

            dataAccess.ReadOnly = true;
            dataAccess.EditMode = DataGridViewEditMode.EditProgrammatically;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            editButton.Visible = true;
            CancelChanges(dataAccess, originalData);
        }
        
       
        
        private void confirmButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = true;
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            dataAccess.ReadOnly = true;
            dataAccess.EditMode = DataGridViewEditMode.EditProgrammatically;
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
       
        private void dataAccess_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccessForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            DataTable data = new Access().LoadData();
            foreach(DataRow row in data.Rows)
            {
                ReadSingleRow(dataAccess, row);
            }
            originalData = data.Copy();
        }
    }
}
