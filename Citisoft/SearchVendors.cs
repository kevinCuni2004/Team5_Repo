using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
