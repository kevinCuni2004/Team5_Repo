//libraries
using System;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class AdminHomePageForm : Form
    {
        private string email;
        //Ivan made
        public AdminHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //go to user tab form
        public AdminHomePageForm(string email)
        {
            this.email = email;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm(email);
            this.Hide();
            usertabForm.ShowDialog();
            this.Show();
            
        }
        //just hide this form(go to log in form)
        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //go to help request form
        private void helpreQuestButton_Click(object sender, EventArgs e)
        {
            HelpRequestForm form = new HelpRequestForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        //go to records form
        private void viewRecordsButton_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm();
            this.Hide();
            recordsForm.ShowDialog();
            this.Show();

        }
        //go to access form
        private void viewAccessButton_Click(object sender, EventArgs e)
        {
            AccessForm accessForm = new AccessForm();
            this.Hide();
            accessForm.ShowDialog();
            this.Show();
        }
        //go to search form
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            this.Hide();
            searchForm.Show();
            this.Show();

        }
        //not needed method(by accident)
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
