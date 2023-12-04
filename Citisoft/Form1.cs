using System;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        private DatabaseHelper _dbHelper;

        public Form1()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper("path_to_your_Messages.db"); // Adjust the path to your database file
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                string timestamp = DateTime.Now.ToString("g");
                _dbHelper.AddMessage(message, timestamp); // Save the message to the database

                MessageBox.Show("Message successfully sent to Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear(); // Clear the text box after sending the message
            }
            else
            {
                MessageBox.Show("Please enter a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}