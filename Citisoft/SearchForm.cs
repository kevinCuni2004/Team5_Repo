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
using System.Data.Odbc;

namespace Citisoft
{
    public partial class SearchForm : Form
    {
        bool found = false;
        private SearchVendors searchVendor;
        private Search search;
        public SearchForm()
        {
            InitializeComponent();
            search = new Search();
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
            
            TermsOfUsecs termsOfUse = new TermsOfUsecs();
            termsOfUse.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string enteredText = searchTextBox.Text;
            string searchText = searchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                
               // DataTable results = new DataTable();
                //SearchVendors searchVendorsForm = new SearchVendors();
                SqlDataReader reader = search.SearchVendors(searchText);
                if (reader != null)
                {
                   // searchVendors.searchText = searchText;
                    //searchVendorsForm.ShowCurrentPage();
                    searchVendor.DisplaySearchResults(reader);
                    searchVendor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No results found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

}
