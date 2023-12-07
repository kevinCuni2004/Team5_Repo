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
        private LogIn logIn;
        public WelcomeForm()
        {

            InitializeComponent();
            signUp = new SignUp();
            logIn = new LogIn();
            StartPosition = FormStartPosition.CenterScreen;

        }

        //if user clicks signUp, user changes the form to proceed signUp 
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(signUp);
            signUpForm.Show();
        }

        // if user clicks logIn, user changes the form to proceed logIn
        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm(logIn);
            logInForm.Show();
        }

        //there is no HelpForm yet, so i cannot connect it

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //i will add some code after creation of Help
        }
    }
}
