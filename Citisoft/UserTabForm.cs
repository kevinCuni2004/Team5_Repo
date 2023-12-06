using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            changeDetailsTabControl.Visible = false;
            changeDetailsTabControl.ItemSize = new Size(0, 1);
            userTab = new UserTab();
        }

        public void updateFields(Profile user) {
            User = user;
            emailLabel.Text = User.Email;
            fnameLabel.Text = User.FirstName;
            lnameLabel.Text = User.LastName;
            dobLabel.Text = User.DateofBirth.ToShortDateString();
            descriptionLabel.Text = User.Details;
            DateTime compareDOB = new DateTime(2000, 1, 1);
            if (User.FirstName == "name" || User.LastName == "surname" || User.DateofBirth.Equals(compareDOB))
            {
                updateInfoLabel.Visible = true;
            }
            else
            {
                updateInfoLabel.Visible = false;
            }
        }


        private void Help_Button_Click(object sender, EventArgs e)
        {
            //HelpDesk
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot change your e-mail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {
            changeFNamePanel.Visible = true;
            changeDetailsTabControl.SelectedTab = changeFNameTab;
            changeDetailsTabControl.Visible = true;
        }

        private void cancelFNameChange_Click(object sender, EventArgs e)
        {
            changeFNamePanel.Visible = false;
            changeDetailsTabControl.Visible = false;
        }

        
        private void lnameLabel_Click(object sender, EventArgs e)
        {
            changeLNamePanel.Visible = true;
            changeDetailsTabControl.SelectedTab = changeLNameTab;
            changeDetailsTabControl.Visible = true;
        }

        private void descTitleLabel_Click(object sender, EventArgs e)
        {
            changeDescPanel.Visible = true;
            changeDetailsTabControl.SelectedTab = changeDescTab;
            changeDetailsTabControl.Visible = true;
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {
            changeDescPanel.Visible = true;
            changeDetailsTabControl.SelectedTab = changeDescTab;
            changeDetailsTabControl.Visible = true;
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {
            changePasswordPanel.Visible = true;
            changeDetailsTabControl.SelectedTab = changePasswordTab;
            changeDetailsTabControl.Visible = true;
        }

        private void cancelPassChangeButton_Click(object sender, EventArgs e)
        {
            changePasswordPanel.Visible = false;
            changeDetailsTabControl.Visible = false;
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
                        dBConnection.ExecutenNonQuery("Profile", "password", User.Password, User.Email);
                        MessageBox.Show("Password changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changePasswordPanel.Visible = false;
                        changeDetailsTabControl.Visible = false;
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
            if (changeFNameTextBox.Text == confirmFNameTextBox.Text)
            {
                if (!String.IsNullOrWhiteSpace(changeFNameTextBox.Text))
                {
                    if (!Regex.IsMatch(changeFNameTextBox.Text, "^[A-Z][a-zA-Z]*$"))
                    {
                        MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        changeFNameTextBox.Text = "";
                        confirmFNameTextBox.Text = "";
                    }
                    else
                    {
                        User.FirstName = changeFNameTextBox.Text;
                        dBConnection = DBConnection.getInstance();
                        dBConnection.ExecutenNonQuery("Profile", "first_name", User.FirstName, User.Email);
                        MessageBox.Show("First Name changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeFNamePanel.Visible = false;
                        changeDetailsTabControl.Visible = false;
                        updateFields(User);
                    }
                }
                else
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changeFNameTextBox.Text = "";
                    confirmFNameTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Names do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeFNameTextBox.Text = "";
                confirmFNameTextBox.Text = "";
            }
        }

        private void dobLabel_Click(object sender, EventArgs e)
        {
            DateTime compareDateTime = new DateTime(2000,01,01);
            if(User.DateofBirth.Equals(compareDateTime))
            {
                changeDetailsTabControl.Visible = true;
                changeDetailsTabControl.SelectedTab = changeDOBTab;
                changeDOBPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("You cannot change your date of birth!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeLNameButton_Click(object sender, EventArgs e)
        {
            if (changeLNameTextBox.Text == confirmLNameTextBox.Text)
            {
                if (!String.IsNullOrWhiteSpace(changeLNameTextBox.Text))
                {
                    if (!Regex.IsMatch(changeLNameTextBox.Text, "^[A-Z][a-zA-Z]*$"))
                    {
                        MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        changeLNameTextBox.Text = "";
                        confirmLNameTextBox.Text = "";
                    }
                    else
                    {
                        User.LastName = changeLNameTextBox.Text;
                        dBConnection = DBConnection.getInstance();
                        dBConnection.ExecutenNonQuery("Profile", "last_name", User.LastName, User.Email);
                        MessageBox.Show("Last Name changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeLNamePanel.Visible = false;
                        changeDetailsTabControl.Visible = false;
                        updateFields(User);
                    }
                }
                else
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changeFNameTextBox.Text = "";
                    confirmFNameTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Names do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeFNameTextBox.Text = "";
                confirmFNameTextBox.Text = "";
            }
        }

        private void cancelDescButton_Click(object sender, EventArgs e)
        {
            changeDescPanel.Visible = false;
            changeDetailsTabControl.Visible = false;
        }

        private void cancelLNameButton_Click(object sender, EventArgs e)
        {
            changeLNamePanel.Visible = false;
            changeDetailsTabControl.Visible = false;
        }

        private void changeDescButton_Click(object sender, EventArgs e)
        {
            if ((changeDescTextBox.Text).Length < 500)
            {
                User.Details = changeDescTextBox.Text;
                dBConnection = DBConnection.getInstance();
                dBConnection.ExecutenNonQuery("Profile", "details", User.Details, User.Email);
                MessageBox.Show("Description changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changeDescPanel.Visible = false;
                changeDetailsTabControl.Visible = false;
                updateFields(User);
            }
            else
            {
                MessageBox.Show("Please keep your description under 500 letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeDescTextBox.Text = "";
            }
        }

        private void cancelDOBButton_Click(object sender, EventArgs e)
        {
            changeDOBPanel.Visible = false;
            changeDetailsTabControl.Visible = false;
        }

        private void changeDOBButton_Click(object sender, EventArgs e)
        {
            User.DateofBirth = new DateTime(Convert.ToInt32(DOB_Year.Value), Convert.ToInt32(DOB_Month.Value), Convert.ToInt32(DOB_Day.Value));
            dBConnection = DBConnection.getInstance();
            dBConnection.ExecutenNonQuery("Profile", "date_of_birth", User.DateofBirth.ToShortDateString(), User.Email);
            MessageBox.Show("Date of Birth set.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            changeDOBPanel.Visible = false;
            changeDetailsTabControl.Visible = false;
            updateFields(User);
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.Show();
        }
    }
}
