using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class SearchVendors : Form
    {
        private List<Panel> allPanels;
        bool found = false;
        private int currentPageIndex;
        private int currentLocation = 29;
        public SearchVendors()
        {
            InitializeComponent();
            InitializeVendorPanels();
            FetchVendorDataFromDatabase(); // Fetch vendor data when the form is initialized
            ShowCurrentPage();
        }

        private void FetchVendorDataFromDatabase()
        {
            string query = "SELECT company_name, company_website FROM Companies";
            DataTable vendorData = GetDataFromDatabase(query);

            if (vendorData != null && vendorData.Rows.Count > 0)
            {
                int panelIndex = 0;

                foreach (DataRow row in vendorData.Rows)
                {
                    Panel panel = allPanels[panelIndex];
                    LinkLabel linkLabel = panel.Controls.OfType<LinkLabel>().FirstOrDefault();

                    if (linkLabel != null)
                    {
                        linkLabel.Text = row["company_name"].ToString();
                        
                    }

                    panelIndex++;

                    if (panelIndex >= allPanels.Count)
                    {
                        break; // Stop if we have populated all panels
                    }
                }
            }
        }

        private DataTable GetDataFromDatabase(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
                return null;
            }
        }

        public void ShowCorrectVendorPanel(string enteredText)
        {
            noResultsLabel.Visible = false;
            var vendorPanels = this.Controls.OfType<Panel>();
            foreach (var panel in vendorPanels)
            {
                LinkLabel linkLabel = panel.Controls.OfType<LinkLabel>().FirstOrDefault();
                if(linkLabel != null && linkLabel.Text == enteredText)
                {
                    panel.Visible = true;
                    panel.Location = new System.Drawing.Point(29, 100);
                    found = true;
                    return;
                }

            }
            if (!found)
            {
                noResultsLabel.Visible = true;
            }
        }
        private void InitializeVendorPanels()
        {
            allPanels = new List<Panel>
            {
                vendorPanel1,
                vendorPanel2,
                vendorPanel3,
                vendorPanel4,

            };
            currentPageIndex = 0;
        }
        private void ShowCurrentPage()
        {
            foreach (var panel in allPanels)
            {
                panel.Visible = false;
            }
            for(int i = currentPageIndex * 4; i < (currentPageIndex + 1) * 4 && i < allPanels.Count; i++)
            {
                allPanels[i].Visible = true;
                allPanels[i].Location = new Point(currentLocation, 100);
                currentLocation += allPanels[i].Width + 30;
            }
            currentLocation = 29;
        }
        private void ShowNextPage()
        {
            currentPageIndex++;
            if(currentPageIndex >= (int)Math.Ceiling((double)allPanels.Count / 4))
            {
                currentPageIndex = 0;
            }
            ShowCurrentPage();
        }
        public void HidePanels()
        {
            var vendorPanels = this.Controls.OfType<Panel>();
            foreach(var panel in vendorPanels)
            {
                panel.Visible = false;
            }
            panel1.Visible = true;
            noResultsLabel.Visible= false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void usernameButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        private void termsOfUseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SearchVendors_Load(object sender, EventArgs e)
        {
            
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            ShowNextPage();
        }
    }
}
