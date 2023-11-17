using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Citisoft
{
    public partial class SignUpForm : Form
    {
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button SignUpButton;


        //private const string ConnectionString = path;

        public SignUpForm()
        {
            InitializeComponent();

        }
 
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            //validation 

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter bothemail and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // add other validation 

            if (SaveCredentialsToDatabase(email, password))
            {
                MessageBox.Show("Signup is successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close;
            }
            else
            {
                MessageBox.Show("Error.Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveCredentialsToDatabase(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Email, PAssword) VALUES (@Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);


                }

            }
        }

        private void InitializeComponent()
        {
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(76, 112);
            this.emailTextBox.Name = "textBox1";
            this.emailTextBox.Size = new System.Drawing.Size(143, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox);
            // 
            // SignUpForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.emailTextBox);
            this.Name = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}