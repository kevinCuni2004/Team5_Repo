﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class LogInForm : Form
    {
        private LogIn logIn;
        private Profile user;
        public LogInForm(LogIn logInInstance)
        {
            InitializeComponent();
            logIn = logInInstance;
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            (string authenticationMessage, Profile userProfile) = logIn.AuthenticateUser(email, password);
            if (authenticationMessage == "Success")
            {
                MessageBox.Show("Log in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                user = userProfile;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Authentication failed: {authenticationMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
