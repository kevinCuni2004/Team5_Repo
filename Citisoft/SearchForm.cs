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
            StartPosition = FormStartPosition.CenterScreen;

            this.Load += new System.EventHandler(this.SearchForm_Load);
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm usertabForm = new UserTabForm();
            usertabForm.Show();
            this.Hide();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            form.Show();
        }

        private void termsOfUseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermsOfUseForm termsOfUse = new TermsOfUseForm();
            termsOfUse.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string enteredText = searchTextBox.Text;
            string searchText = searchTextBox.Text.Trim();
            string cityFilter = (cityComboBox.SelectedItem as string)?.Trim();
            string countryFilter = (countryComboBox.SelectedItem as string)?.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                
              
                SqlDataReader reader = search.SearchVendors(searchText, cityFilter,  countryFilter);

                if (reader != null)
                {
           
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

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //Populate the ComboBoxes with distinct cities and countries
            PopulateCityComboBox();
            PopulateCountryComboBox();
        }

        private void PopulateCityComboBox()
        {
            List<string> cities = search.GetDistinctCities(); // Implement this method in your Search class

            cityComboBox.Items.Clear();
            cityComboBox.Items.Add(""); // Add an empty option for no filtering
            cityComboBox.Items.AddRange(cities.ToArray());
        }

        private void PopulateCountryComboBox()
        {
            List<string> countries = search.GetDistinctCountries(); // Implement this method in your Search class

            countryComboBox.Items.Clear();
            countryComboBox.Items.Add(""); // Add an empty option for no filtering
            countryComboBox.Items.AddRange(countries.ToArray());
            Console.WriteLine("Countries:" + string.Join(", ", countries));
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
