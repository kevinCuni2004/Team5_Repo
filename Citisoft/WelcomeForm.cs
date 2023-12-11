using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        public UserTabForm UserTabForm
        {
            get => default;
            set
            {
            }
        }

        public LogInForm LogInForm
        {
            get => default;
            set
            {
            }
        }

        //if user clicks signUp, user changes the form to proceed signUp 
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(signUp);
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }

        // if user clicks logIn, user changes the form to proceed logIn
        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm(logIn);
            this.Hide();
            logInForm.ShowDialog();
            this.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            this.Hide();
            helpForm.ShowDialog();
        }
        //Ivan
        private void tutorialsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pdfFolder = Path.Combine(Application.StartupPath, "PDFs");
            Console.WriteLine(pdfFolder);
            string pdfFileName = $"Tutorials.pdf";
            string pdfPath = Path.Combine(pdfFolder, pdfFileName);
            try
            {
                Process.Start(pdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can not open PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
