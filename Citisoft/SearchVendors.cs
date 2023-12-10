using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
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
            ShowCurrentPage();
            search = new Search();
            StartPosition = FormStartPosition.CenterScreen;

            foreach (var control in allCompanyControls)
            {
                control.CompanyClicked += CompanyUserControl_Clicked;
                Debug.WriteLine($"Subscribed to CompanyClicked event for control with CompanyID: {control.CompanyID}");
            }
        }


        // Display panels for the search results
        public void DisplaySearchResults(SqlDataReader reader)
        {

            ClearControls();

            // using reader to find info from the database
            using (reader)
            {
                //error handling
                if (reader == null) Console.WriteLine("It's empty.");

                while (reader.Read())
                {
                    // displaying info on panels
                    int companyId = reader.GetInt32(reader.GetOrdinal("company_id"));
                    string companyName = reader.GetString(reader.GetOrdinal("company_name"));
                    string companyWebsite = reader.GetString(reader.GetOrdinal("company_website"));
                    

                    // creating panel for the company
                    CompanyUserControl companyUserControl = new CompanyUserControl(companyId, companyName, companyWebsite);

        

                    allCompanyControls.Add(companyUserControl);
                    flowLayoutPanel.Controls.Add(companyUserControl);


                }
            }
        }
        

        // trigger to open PDF file of the vendor 
        private void CompanyUserControl_Clicked(object sender, EventArgs e)
        {
            if (sender is CompanyUserControl clickedControl)
            {
                // Get the company ID from the clicked control
                int companyId = clickedControl.CompanyID;

                // PDFs are stored in a folder named "PDFs" within  program directory
                string pdfFolder = @"C:/Users/DELL/source/repos/justtaaa/kevinCuni2004/PDFs";

                // Construct the PDF file path based on the company ID
                string pdfFileName = $"{companyId}.pdf";
                string pdfPath = Path.Combine(pdfFolder, pdfFileName);


                Debug.WriteLine($"Attempting to open PDF at folder: {pdfFolder}");
                Debug.WriteLine($"Attempting to open PDF at name: {pdfFileName}");
                Debug.WriteLine($"Attempting to open PDF at path: {pdfPath}");

                // Open the PDF file using the default PDF viewer

                try
                {
                    Process.Start(pdfPath);
                }

                catch(Exception ex)
                {
                    MessageBox.Show("PDF not found for the selected company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }


        // clearing panels for information
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
            
            vScrollBar = new VScrollBar
            {
                Dock = DockStyle.Right,
                SmallChange = 1,
                LargeChange = 1

            };

            vScrollBar.Scroll += vScrollBar1_Scroll;
            this.Controls.Add(vScrollBar);

            allCompanyControls = new List<CompanyUserControl>();
        }
           
        
        // show the page with the results
        public void ShowCurrentPage()
        {
            int panelsWidth = 148;
            int panelsHeight = 149;
            int panelsHGap = 20;
            int panelsVGap = 40;
            int panelsRow = flowLayoutPanel.Width / (panelsWidth + panelsHGap);
            int totalWidth = panelsRow * (panelsWidth + panelsHGap) - panelsHGap;
            int countX = (flowLayoutPanel.Width - totalWidth / 2);
            int countY = (flowLayoutPanel.Width - panelsHeight - panelsVGap) / 2;
            ClearControls();
            for (int i = currentPageIndex * 4, row = 0, col = 0; i < (currentPageIndex + 1) * 4 && i < allCompanyControls.Count; i++, col++)
            {
                if (col >= panelsRow)
                {
                    col = 0;
                    row++;
                }
                int x = countX + col * (panelsWidth + panelsHGap);
                int y = countY + row * (panelsHeight + panelsVGap);
                allCompanyControls[i].Location = new Point(x, y);
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

        // sends to usertab
        private void usernameButton_Click(object sender, EventArgs e)
        {
            UserTabForm userTab = new UserTabForm();
            userTab.Show();
        }

        // sends to help centre
        private void helpButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.Show();
        }

        // go back to search again
        private void backButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        // shows terms of use and privacy policy
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

       
        // with the scrolling next 4 panels displaying 
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = vScrollBar1.Value;
            int startIndex = scrollValue * 4;
            
            HidePanels();

            for (int i = startIndex; i < Math.Min(allCompanyControls.Count, startIndex + 4); i++)
            {
                if(i >= 0 && i < allCompanyControls.Count)
                {
                    allCompanyControls[i].Visible = true;
                }
                
            }

        }

        private void noResultsLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
