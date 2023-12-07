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
    public partial class AdminHomePageForm : Form
    {
        public AdminHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm();
            usertabForm.Show();
            this.Hide();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {

        }

        private void helpreQuestButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.Show();

        }

        private void viewRecordsButton_Click(object sender, EventArgs e)
        {

        }

        private void viewAccessButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
