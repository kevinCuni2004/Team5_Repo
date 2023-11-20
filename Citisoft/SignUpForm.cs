﻿using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using Citisoft;

namespace Citisoft
{
    public partial class SignUpForm : Form
    {
        private SignUp signUp;
       
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button SignUpButton;
        private Button helpButton;
        private Button backButton;
        private TextBox textBox1;

        public SignUpForm(SignUp signUpInstance)
        {
            InitializeComponent();
            signUp = new SignUp();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            string registrationMessage = signUp.RegisterUser(email, password);

            //validation 

            /*if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            if (registrationMessage == "Success")
            {
                MessageBox.Show("SignUp is successful! Proceed to login",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Registration failed: {registrationMessage}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(199, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 26);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(199, 164);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(251, 26);
            this.passwordTextBox.TabIndex = 1;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(372, 215);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(78, 43);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.Text = "SignUpButton";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(538, 27);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(106, 48);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(24, 304);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 47);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(246, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Please enter";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignUpForm
            // 
            this.ClientSize = new System.Drawing.Size(668, 367);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Name = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}