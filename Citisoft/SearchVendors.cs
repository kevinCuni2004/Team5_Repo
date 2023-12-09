using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Citisoft
{
    public partial class SearchVendors : Form
    {
        //Kevin
        private DBConnection dbConnection;
        public SqlDataReader dataReader;
        //

        private int currentPageIndex;
        public string searchText;
        private Search search;

        //taya
        private FlowLayoutPanel flowLayoutPanel;
        private List<CompanyUserControl> allCompanyControls;
        private VScrollBar vScrollBar;
        public SearchVendors()
        {
            InitializeComponent();
            InitializeVendorPanels();
            FetchVendorDataFromDatabase(); // Fetch vendor data when the form is initialized
            ShowCurrentPage();
            search = new Search();
            StartPosition = FormStartPosition.CenterScreen;

            foreach (var control in allCompanyControls)
            {
                control.CompanyClicked += CompanyUserControl_Clicked;
            }
        }

        private void FetchVendorDataFromDatabase()
        {
            string connectionString = Properties.Settings.Default.DBConnectionString;
           
        }


       

        public void DisplaySearchResults(SqlDataReader reader)
        {
            // Display panels for the search results
            ClearControls();
            
            using (reader)
            {
                if (reader == null) Console.WriteLine("It's empty.");

                while (reader.Read())
                {

                    string companyName = reader.GetString(reader.GetOrdinal("company_name"));
                    string companyWebsite = reader.GetString(reader.GetOrdinal("company_website"));

                    CompanyUserControl companyUserControl = new CompanyUserControl(companyName, companyWebsite);
                    allCompanyControls.Add(companyUserControl);
                    flowLayoutPanel.Controls.Add(companyUserControl);

                   
                }
            }
        }

        private void CompanyUserControl_Clicked(object sender, EventArgs e)
        {
            if (sender is CompanyUserControl clickedControl)
            {
                // Get the company ID from the clicked control
                int companyId = clickedControl.CompanyID;

                // PDFs are stored in a folder named "PDFs" within  program directory
                string pdfFolder = Path.Combine(Application.StartupPath, "PDFs");

                // Construct the PDF file path based on the company ID
                string pdfFileName = $"{companyId}.pdf";
                string pdfPath = Path.Combine(pdfFolder, pdfFileName);

                // Open the PDF file using the default PDF viewer
                if (File.Exists(pdfPath))
                {
                    System.Diagnostics.Process.Start(pdfPath);
                }
                else
                {
                    MessageBox.Show("PDF not found for the selected company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void ClearControls()
        {
            flowLayoutPanel.Controls.Clear();
            allCompanyControls.Clear();
        }

        private void InitializeVendorPanels()
        {
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(flowLayoutPanel);

            vScrollBar1 = new VScrollBar
            {
                Dock = DockStyle.Right,
                SmallChange = 1,
                LargeChange = 1

            };

            vScrollBar1.Scroll += vScrollBar1_Scroll;
            this.Controls.Add(vScrollBar);

            allCompanyControls = new List<CompanyUserControl>();
        }
           
        
        public void ShowCurrentPage()
        {

            ClearControls();
            for (int i = currentPageIndex * 4; i < (currentPageIndex+1) *4 && i< allCompanyControls.Count; i++)
            {
                allCompanyControls[i].Visible = true;
                flowLayoutPanel.Controls.Add(allCompanyControls[i]);
            }
           
        }
        public void HidePanels()
        {
            foreach (var control in allCompanyControls)
            {
                control.Visible = false;
            }


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
            UserTabForm userTab = new UserTabForm();
            userTab.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.Show();
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
            TermsOfUseForm terms = new TermsOfUseForm();
            terms.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SearchVendors_Load(object sender, EventArgs e)
        {
            
        }

       

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = vScrollBar1.Value;
            int startIndex = scrollValue * 4;
            int endIndex = Math.Min(startIndex + 4, allCompanyControls.Count);
            ClearControls();
            for (int i = startIndex; i < endIndex; i++)
            {
                allCompanyControls[i].Visible = true;
            }

        }

        private void noResultsLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
