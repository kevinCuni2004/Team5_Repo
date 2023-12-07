﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Citisoft
{
    public partial class SearchVendors : Form
    {
        //Kevin
        private DBConnection dBConnection;
        public SqlDataReader dataReader;
        //
        private List<Panel> allPanels;
        bool found = false;
        private int currentPageIndex;
        private int currentLocation = 29;
        private int company_id = 0;
        public string searchText;
        public SearchVendors()
        {
            InitializeComponent();
            InitializeVendorPanels();
            FetchVendorDataFromDatabase(); // Fetch vendor data when the form is initialized
            ShowCurrentPage();
        }

        private void FetchVendorDataFromDatabase()
        {
            string connectionString = Properties.Settings.Default.DBConnectionString;
            //string query = "SELECT [company_name], [company_website]  FROM [Companies] ";
            //DataTable vendorData = GetDataFromDatabase(query, connectionString);

            /*if (vendorData != null && vendorData.Rows.Count > 0)
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
            else
            {
                noResultsLabel.Visible = true;
            }*/
        }

        private Panel panelTemplate()
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
        }

        public SqlDataReader GetVendorData(string searchText)
        {
            dBConnection = DBConnection.getInstance();
            string sqlQuery = "SELECT * FROM [Companies] WHERE " +
                    "[company_name] LIKE @SearchText OR " +
                    "[company_website] LIKE @SearchText OR " +
                    "EXISTS (SELECT 1 FROM [Products] WHERE [Companies].[company_id] = [Products].[company_id] AND " +
                    "([description] LIKE @SearchText OR [cloud] LIKE @SearchText OR [software_name] LIKE @SearchText))";
            SqlCommand command = new SqlCommand(sqlQuery);
            command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
            SqlDataReader reader = dBConnection.ExcecuteReader(command);
            return reader;
        }

        private DataTable GetDataFromDatabase(string query, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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


        public void DisplaySearchResults(/*DataTable searchResults*/ SqlDataReader reader)
        {
            // Display panels for the search results
            int panelIndex = 0;
            /*foreach (DataRow row in searchResults.Rows)
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
            }*/
            //Kevin Implemented this
            using (reader)
            {
                if (reader == null) Console.WriteLine("It's empty.");
                while (reader.Read())
                {
                    if (company_id == reader.GetInt32(reader.GetOrdinal("company_id")))
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

                    panelIndex++;
                }
            }
            int x = 33;
            foreach (var panels in allPanels)
            {
                panels.Size = new Size(178, 245);
                panels.Location = new Point(x, 100);
                panels.Show();
                x += 33;
                x += 178;
            }
        }

        private void InitializeVendorPanels()
        {
            allPanels = new List<Panel>{};
            currentPageIndex = 0;
        }
        public void ShowCurrentPage()
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
            //DisplaySearchResults(GetVendorData(searchText));
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
