//libraries
using System;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class AdminHomePageForm : Form
    {
        //Ivan made
        public AdminHomePageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //go to user tab form
        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm();
            usertabForm.Show();
            this.Hide();
        }
        //just hide this form(go to log in form)
        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        //go to help request form
        private void helpreQuestButton_Click(object sender, EventArgs e)
        {
            HelpRequestForm form = new HelpRequestForm();
            form.Show();
        }
        //go to records form
        private void viewRecordsButton_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
            this.Hide();
        }
        //go to access form
        private void viewAccessButton_Click(object sender, EventArgs e)
        {
            AccessForm accessForm = new AccessForm();
            accessForm.Show();
            this.Hide();
        }
        //go to search form
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }
        //not needed method(by accident)
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
