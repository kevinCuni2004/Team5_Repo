using System;
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
    public partial class HelpForm : Form
    {
        //private DatabaseHelper _dbHelper;

        public HelpForm()
        {
            InitializeComponent();
            //_dbHelper = new DatabaseHelper("path_to_your_Messages.db"); // Adjust the path to your database file
        }

        internal DBConnection DBConnection
        {
            get => default;
            set
            {
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                string timestamp = DateTime.Now.ToString("g");
               // _dbHelper.AddMessage(message, timestamp); // Save the message to the database

                MessageBox.Show("Message successfully sent to Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear(); // Clear the text box after sending the message
            }
            else
            {
                MessageBox.Show("Please enter a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
