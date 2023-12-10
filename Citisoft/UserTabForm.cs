﻿using System;
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
        //Initialize fields
        private UserTab userTab; //backend class for this form
        private Profile User; //Profile object for the user info
        private WelcomeForm welcomeForm; //Welcome form initialization for logging out 
        public UserTabForm()
        {
            InitializeComponent();//Auto generated by visual studio to initialize form components
            changeDetailsTabControl.Visible = false;
            changeDetailsTabControl.ItemSize = new Size(0, 1);//Used to hide the tab names
            userTab = UserTab.getInstance();//get instance of UserTab, or create new one
            StartPosition = FormStartPosition.CenterScreen;
        }

        public UserTabForm(Profile user)//constructor to pass the user info to the form
        {
            this.User = user;
            InitializeComponent();
            changeDetailsTabControl.Visible = false;
            changeDetailsTabControl.ItemSize = new Size(0, 1);
            userTab = new UserTab();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void updateFields(Profile user) { //method to update the labels in the form
            User = user;
            emailLabel.Text = User.Email;
            fnameLabel.Text = User.FirstName;
            lnameLabel.Text = User.LastName;
            dobLabel.Text = User.DateofBirth.ToShortDateString();
            descriptionLabel.Text = User.Details;
            DateTime compareDOB = new DateTime(2000, 1, 1);
            //check if the user info is the Defaults from the Sql Create statement
            if (User.FirstName == "name" || User.LastName == "surname" || User.Username =="username" || User.DateofBirth.Equals(compareDOB))
            {
                changeDetailsTabControl.Visible = true;
                changeDetailsTabControl.SelectedTab = newUserTab;
                newUserPanel.Visible = true;
                //if so propmpt the user to enter their details using newUserTab tab control
            }
            else
            {
                changeDetailsTabControl.Visible = false;
            }
        }


        private void Help_Button_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            //show help form
            form.Show();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            //close the form to go back at the previous form
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
            userTab = UserTab.getInstance();
            if (BCrypt.Net.BCrypt.Verify(oldPassTextBox.Text, User.Password))
            {
                if (userTab.checkPassword(newPassTextBox.Text))
                {
                    if (newPassTextBox.Text == confirmNewPassTextBox.Text)
                    {
                        if (userTab.updatePassword(newPassTextBox.Text, User.Email) == "Failed Encrypition" ||
                            userTab.updatePassword(newPassTextBox.Text, User.Email) == "Failed database connection")
                        {
                            MessageBox.Show("Error changing password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            oldPassTextBox.Text = "";
                            newPassTextBox.Text = "";
                            confirmNewPassTextBox.Text = "";
                        } else
                        {
                            User.Password = userTab.updatePassword(newPassTextBox.Text, User.Email);
                        }
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
            userTab = UserTab.getInstance();
            if (!String.IsNullOrWhiteSpace(changeFNameTextBox.Text))
            {
                if (!userTab.checkName(changeFNameTextBox.Text))
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changeFNameTextBox.Text = "";
                }
                else
                {
                    userTab.updateName(changeFNameTextBox.Text, 1, User.Email);
                    if (userTab.updateName(changeFNameTextBox.Text, 1, User.Email) == "Failed executing query")
                    {
                        MessageBox.Show("Error in updating data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (userTab.updateName(changeFNameTextBox.Text, 1, User.Email) == "Failed database connection")
                    {
                        MessageBox.Show("Error connecting to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User.FirstName = userTab.updateName(changeFNameTextBox.Text, 1, User.Email);
                        MessageBox.Show("First Name changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeFNamePanel.Visible = false;
                        changeDetailsTabControl.Visible = false;
                        updateFields(User);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeFNameTextBox.Text = "";
            }
        }

        private void changeLNameButton_Click(object sender, EventArgs e)
        {
            userTab = UserTab.getInstance();
            if (!String.IsNullOrWhiteSpace(changeLNameTextBox.Text))
            {
                if (!userTab.checkName(changeLNameTextBox.Text))
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changeLNameTextBox.Text = "";
                }
                else
                {
                    userTab.updateName(changeLNameTextBox.Text, 2, User.Email);
                    if (userTab.updateName( changeLNameTextBox.Text, 2, User.Email) == "Failed executing query")
                    {
                        MessageBox.Show("Error in updating data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (userTab.updateName(changeLNameTextBox.Text, 2, User.Email) == "Failed database connection")
                    {
                        MessageBox.Show("Error connecting to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        User.FirstName = userTab.updateName(changeLNameTextBox.Text, 2, User.Email);
                        MessageBox.Show("Last Name changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeFNamePanel.Visible = false;
                        changeDetailsTabControl.Visible = false;
                        updateFields(User);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeLNameTextBox.Text = "";
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
            userTab = UserTab.getInstance();
            if ((changeDescTextBox.Text).Length < 500)
            {
                if (userTab.updateDetails(changeDescTextBox.Text, User.Email) == "Failed database connection")
                {
                    MessageBox.Show("Failed connection to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changeDescTextBox.Text = "";
                }
                else
                {
                    User.Details = userTab.updateDetails(changeDescTextBox.Text, User.Email);
                    MessageBox.Show("Description changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changeDescPanel.Visible = false;
                    changeDetailsTabControl.Visible = false;
                    updateFields(User);
                }
            }
            else
            {
                MessageBox.Show("Please keep your description under 500 letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeDescTextBox.Text = "";
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            welcomeForm = new WelcomeForm();
            this.Close();
            welcomeForm.ShowDialog();
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            userTab = UserTab.getInstance();
            //Username
            if (userTab.updateUsername(setUsernameTextBox.Text, User.Email) == "Failed database connection")
            {
                MessageBox.Show("Failed connection to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changeDescTextBox.Text = "";
                flag = false;
            }
            else
            {
                User.Username = userTab.updateUsername(setUsernameTextBox.Text, User.Email);
            }
            //First Name
            if (!String.IsNullOrWhiteSpace(setFNameTextBox.Text))
            {
                if (!userTab.checkName(setFNameTextBox.Text))
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setFNameTextBox.Text = "";
                }
                else
                {
                    userTab.updateName(setFNameTextBox.Text, 1, User.Email);
                    if (userTab.updateName(setFNameTextBox.Text, 1, User.Email) == "Failed executing query")
                    {
                        MessageBox.Show("Error in updating data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = false;
                    }
                    else if (userTab.updateName(setFNameTextBox.Text, 1, User.Email) == "Failed database connection")
                    {
                        MessageBox.Show("Error connecting to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = false;
                    }
                    else
                    {
                        User.FirstName = userTab.updateName(setFNameTextBox.Text, 1, User.Email);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setFNameTextBox.Text = "";
            }
            //Last Name
            if (!String.IsNullOrWhiteSpace(setLNameTextBox.Text))
            {
                if (!userTab.checkName(setLNameTextBox.Text))
                {
                    MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setLNameTextBox.Text = "";
                }
                else
                {
                    userTab.updateName(setLNameTextBox.Text, 2, User.Email);
                    if (userTab.updateName(setLNameTextBox.Text, 2, User.Email) == "Failed executing query")
                    {
                        MessageBox.Show("Error in updating data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = false;
                    }
                    else if (userTab.updateName(setLNameTextBox.Text, 2, User.Email) == "Failed database connection")
                    {
                        MessageBox.Show("Error connecting to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = false;
                    }
                    else
                    {
                        User.LastName = userTab.updateName(setLNameTextBox.Text, 2, User.Email);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setLNameTextBox.Text = "";
            }
            //DOB
            User.DateofBirth = new DateTime(Convert.ToInt32(setDOBYear.Value), Convert.ToInt32(setDOBMonth.Value), Convert.ToInt32(setDOBDay.Value));
            User.DateofBirth = userTab.updateDOB(User.DateofBirth, User.Email);
            DateTime temp = new DateTime(1800, 1, 1);
            if (User.DateofBirth.CompareTo(temp) == 0) {
                MessageBox.Show("Error connecting to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setDOBDay.Value = 1;
                setDOBMonth.Value = 1;
                setDOBYear.Value = 2000;
                flag = false;
            }
            //Description
            if ((setDetailsTextBox.Text).Length < 500)
            {
                if (userTab.updateDetails(setDetailsTextBox.Text, User.Email) == "Failed database connection")
                {
                    MessageBox.Show("Failed connection to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    setDetailsTextBox.Text = "";
                    flag = false;
                }
                else
                {
                    User.Details = userTab.updateDetails(setDetailsTextBox.Text, User.Email);
                }
            }
            else
            {
                MessageBox.Show("Please keep your description under 500 letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setDetailsTextBox.Text = "";
            }

            if (flag == true)
            {
                updateFields(User);
                changeDetailsTabControl.Visible = false;
                MessageBox.Show("Information updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                setFNameTextBox.Text = "";
                setLNameTextBox.Text = "";
                setUsernameTextBox.Text = "";
                setDetailsTextBox.Text = "";
                setDOBDay.Value = 1;
                setDOBMonth.Value = 1;
                setDOBYear.Value = 2000;
            }
        }
    }
}
