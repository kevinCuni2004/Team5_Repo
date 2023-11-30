using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class SearchForm : Form
    {
        bool found = false;
        private SearchVendors searchVendor;
        public SearchForm()
        {
            InitializeComponent();
            searchVendor = new SearchVendors();
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm();
            usertabForm.Show();
            this.Hide();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //--We dont have HelpForm so it doesnt work--//
            //HelpForm helpForm = new HelpTabForm();
            //helpForm.Show();
            //this.Hide();
        }

        private void termsOfUseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //--We dont have TermsOfUseForm so it doesnt work--//
            //TermsOfUseForm termsOfUseForm = new TermsOfUseForm();
            //termsOfUseForm.Show();
            //this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string enteredText = searchTextBox.Text;
            string searchText = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchText));
            {
                DBConnection dbConnection = DBConnection.getInstance();
                string query = "SELECT * FROM Profile WHERE company_name LIKE @searchText;";

                using (SqlCommand command = new SqlCommand(query, dbConnection.getDBConnection()))
                {
                    try
                    {
                        dbConnection.openDBConnection();
                        command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                found = true;
                            }
                            if (!found)
                            {
                                MessageBox.Show("Таких результатов нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                    }
                }
            }
            searchVendor.ShowCorrectVendorPanel(enteredText);
            searchVendor.Show();
            this.Hide();
        }
    }
}
        //-Connect to db-->search by strings from db-->by clicking on the box in SearchForm, we need to search using the words from the attribute(If box was clicked, search from for example: lacation attribute) 
        //-->If there are no match make an error message--//
        //--In general we need to iterate through all attributes and their contents--//

