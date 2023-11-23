using System;
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
        //added this ~Kevin
        private UserTab userTab;
        private UserTabForm userTabForm;
        private Profile user;
        //
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button SignUpButton;
        private Button helpButton;
        private Button backButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;

        public SignUpForm(SignUp signUpInstance)
        {
            InitializeComponent();
            signUp = signUpInstance;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            

            (string registrationMessage, Profile userProfile) = signUp.RegisterUser(email, password);



            if (registrationMessage == "Success")
            {
                MessageBox.Show("SignUp is successful! Proceed to login",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                userTab = new UserTab();
                user = userTab.loadProfile(email);
                userTabForm = new UserTabForm();
                userTabForm.updateFields(user);
                this.Close();
                //this I added ~Kevin
                userTabForm.ShowDialog();
                //
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(199, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 22);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(199, 164);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(251, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(344, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.ClientSize = new System.Drawing.Size(668, 367);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Name = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.tabControl1.ResumeLayout(false);
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

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}