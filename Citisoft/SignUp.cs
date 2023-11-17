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
    private const string ConnectionString = path;

    public SignUpForm()
    {
        InitializeComponent();

    }

    private void SignUpButton_Click(object sender, EventArgs e)
    {
        string email = emailTextBox.Text;
        string password = passwordTextBox.Text;

        //validation 

        if (stringIsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Please enter bothemail and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // add other validation 

        if (SaveCredentialsToDatabase(email, password){
            MessageBox.Show("Signup is successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close;
        }
        else
        {
            MessageBox.Show("Error.Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}