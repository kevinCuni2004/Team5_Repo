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
    public partial class UserTabForm : Form
    {
        private UserTab userTab;
        private Profile user;
        public UserTabForm(Profile user)
        {
            InitializeComponent();
            userTab = new UserTab();
        }

        public void updateFields() {
            emailLabel.Text = user.Email;
            fnameLabel.Text = user.FirstName;
            lnameLabel.Text = user.LastName;
            ageLabel.Text = Convert.ToString(user.Age);
            specialityLabel.Text = "Fix later";
            descriptionLabel.Text = user.Details;
        }


        private void Help_Button_Click(object sender, EventArgs e)
        {
            //HelpDesk
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //go back to Home
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void fnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ageLabel_Click(object sender, EventArgs e)
        {

        }

        private void specialityLabel_Click(object sender, EventArgs e)
        {

        }

        private void descTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
