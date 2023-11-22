using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Citisoft
{
    public partial class UserTabForm : Form
    {
        private UserTab userTab;
        private Profile User;
        private DBConnection dBConnection;
        public UserTabForm()
        {
            InitializeComponent();
            changePasswordPanel.Visible = false;
            changeFNamePanel.Visible = false;
            userTab = new UserTab();
        }

        public void updateFields(Profile user) {
            User = user;
            emailLabel.Text = User.Email;
            fnameLabel.Text = User.FirstName;
            lnameLabel.Text = User.LastName;
            ageLabel.Text = User.DateofBirth.ToShortDateString();
            descriptionLabel.Text = User.Details;
            if (User.FirstName != "name")
            {
                updateInfoLabel.Visible = false;
            }
            else
            {
                updateInfoLabel.Visible = true;
            }
        }


        private void Help_Button_Click(object sender, EventArgs e)
        {
            //HelpDesk
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //go back to Home
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot change your e-mail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {
            changeFNamePanel.Visible = true;
        }

        private void cancelFNameChange_Click(object sender, EventArgs e)
        {
            changeFNamePanel.Visible = false;
        }

        
        private void lnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ageLabel_Click(object sender, EventArgs e)
        {

        }

        private void descTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            changePasswordPanel.Visible = true;
        }

        private void cancelPassChangeButton_Click(object sender, EventArgs e)
        {
            changePasswordPanel.Visible = false;
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            if (User.Password == oldPassTextBox.Text)
            {
                if (Regex.IsMatch(newPassTextBox.Text, @"^(?=.*\d)(?=.*[A-Z])(?=.*[a^zA-Z\d]).{8,25}$"))
                {
                    if (newPassTextBox.Text == confirmNewPassTextBox.Text)
                    {
                        User.Password = newPassTextBox.Text;
                        dBConnection = DBConnection.getInstance();
                        string query = "UPDATE [Profile] SET [password]=@password WHERE [e-mail]=@email;";
                        SqlCommand command = new SqlCommand(query);
                        command.Parameters.AddWithValue("@password", User.Password);
                        command.Parameters.AddWithValue("@email", User.Email);
                        dBConnection.ExecutenNonQuery(command);
                        MessageBox.Show("Password changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changePasswordPanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        oldPassTextBox.Text = "";
                        newPassTextBox.Text = "";
                        confirmNewPassTextBox.Text = "";
                    }
                } else
                {
                    MessageBox.Show("Password must be 8-25 characters long and contain at least:\n  - 1 Uppercase letter\n  - 1 Lowercase letter\n  - 1 Number\n    - 1 Special Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oldPassTextBox.Text = "";
                    newPassTextBox.Text = "";
                    confirmNewPassTextBox.Text = "";
                }
            } else
            {
                MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oldPassTextBox.Text = "";
                newPassTextBox.Text = "";
                confirmNewPassTextBox.Text = "";
            }
        }

        private void changeFNameButton_Click(object sender, EventArgs e)
        {
            if (changeFNameTextBox.Text == confrimFNameTextBox.Text)
            {
                if (!String.IsNullOrWhiteSpace(changeFNameTextBox.Text))
                {
                    if (!Regex.IsMatch(changeFNameTextBox.Text, "^[A-Z][a-zA-Z]*$"))
                    {
                        MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        changeFNameTextBox.Text = "";
                        confrimFNameTextBox.Text = "";
                    }
                    else
                    {
                        User.FirstName = changeFNameTextBox.Text;
                        dBConnection = DBConnection.getInstance();
                        string query = "UPDATE [Profile] SET [first_name]=@firstName WHERE [e-mail]=@email;";
                        SqlCommand command = new SqlCommand(query);
                        command.Parameters.AddWithValue("@firstName", User.FirstName);
                        command.Parameters.AddWithValue("@email", User.Email);
                        dBConnection.ExecutenNonQuery(command);
                        MessageBox.Show("First Name changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeFNamePanel.Visible = false;
                        fnameLabel.Text = User.FirstName;
                    }
                }
                else
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changeFNameTextBox.Text = "";
                    confrimFNameTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Names do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeFNameTextBox.Text = "";
                confrimFNameTextBox.Text = "";
            }
        }
    }
}
