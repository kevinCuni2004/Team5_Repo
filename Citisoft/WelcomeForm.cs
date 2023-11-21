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
    public partial class WelcomeForm : Form
    {

        private SignUp signUp;
        public WelcomeForm()
        {

            InitializeComponent();
            signUp = new SignUp();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(signUp);
            signUpForm.ShowDialog();
        }

       

        private void LogInButton_Click(object sender, EventArgs e)
        {

        }
    }
}
