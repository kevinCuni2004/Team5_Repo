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
        private List<Panel> allPanels;
        bool found = false;
        private int currentPageIndex;
        private int currentLocation = 29;
        private int company_id = 0;
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
        }

        private void FetchVendorDataFromDatabase()
        {
            string connectionString = Properties.Settings.Default.DBConnectionString;
           
        }

        /*private Panel panelTemplate()
        {
            Panel panel = new Panel();
            panel.Size = new Size(178, 245);
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.BackColor = Color.White;
            panel.TabIndex = 11;
            LinkLabel titleLinkLabel = new LinkLabel();
            panel.Controls.Add(titleLinkLabel);
            titleLinkLabel.Size = new Size(171, 71);
            titleLinkLabel.Location = new Point(3, 2);
            titleLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLinkLabel.BorderStyle = BorderStyle.FixedSingle;
            titleLinkLabel.LinkColor = Color.Black;
            titleLinkLabel.TabIndex = 14;
            titleLinkLabel.TabStop = true;
            Label descLabel = new Label();
            panel.Controls.Add(descLabel);
            descLabel.BorderStyle = BorderStyle.FixedSingle;
            descLabel.TextAlign= ContentAlignment.TopCenter;
            descLabel.TabIndex = 14;
            descLabel.Location = new Point(3, 72);
            descLabel.Size = new Size(171, 173);
            return panel;
        }*/

       


        public void DisplaySearchResults(SqlDataReader reader)
        {
            // Display panels for the search results
            ClearControls();
            //int panelIndex = 0;
            //int x = 33;
            
            
            //Kevin Implemented this
            using (reader)
            {
                if (reader == null) Console.WriteLine("It's empty.");
                //int panelIndex = 0;
                while (reader.Read())
                {

                    string companyName = reader.GetString(reader.GetOrdinal("company_name"));
                    string companyWebsite = reader.GetString(reader.GetOrdinal("company_website"));

                    CompanyUserControl companyUserControl = new CompanyUserControl(companyName, companyWebsite);
                    allCompanyControls.Add(companyUserControl);
                    flowLayoutPanel.Controls.Add(companyUserControl);

                    /*if (company_id == reader.GetInt32(reader.GetOrdinal("company_id")))
                    {
                        continue;
                    }
                    Panel panel = panelTemplate();
                    allPanels.Add(panel);

                    LinkLabel linkLabel = panel.Controls.OfType<LinkLabel>().FirstOrDefault();
                    this.Controls.Add(allPanels[panelIndex]);
                    allPanels[panelIndex].Controls.Add(linkLabel);
                    Label label = panel.Controls.OfType<Label>().FirstOrDefault();
                    allPanels[panelIndex].Controls.Add(label);
                    allPanels[panelIndex].Size = new Size(178, 245);
                    panel.Location = new Point(33, 100);
                    if (linkLabel != null)
                    {
                        company_id = reader.GetInt32(reader.GetOrdinal("company_id"));
                        linkLabel.Text = reader.GetString(reader.GetOrdinal("company_name"));
                        label.Text = reader.GetString(reader.GetOrdinal("company_website"));
                    }
                    this.Controls.Add(panel);



                    this.Controls.Add(panel);

                    panelIndex++;*/
                }
            }
            //int x = 33;
            /*foreach (var panels in allPanels)
            {
                panels.Size = new Size(178, 245);
                panels.Location = new Point(x, 100);
                panels.Show();
                x += 33;
                x += 178;
            }*/
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
    }
}
