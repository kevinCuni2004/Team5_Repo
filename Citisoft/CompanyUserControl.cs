using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class CompanyUserControl : UserControl

    {
        public int CompanyID { get; set; }

        public event EventHandler<EventArgs> CompanyClicked;
        public CompanyUserControl(int companyId,string companyName, string companyWebsite)
        {
            InitializeComponent();
            CompanyID = companyId;
            InitializeControl(companyName, companyWebsite);
            this.Click += websiteLabel_Click;

            Debug.WriteLine($"CompanyUserControl created for {companyName} wih ID {CompanyID}");
        }

        private void InitializeControl(string companyName, string companyWebsite)
        {
            titleLabel.Text = companyName;
            websiteLabel.Text = companyWebsite;
        }

        private void websiteLabel_Click(object sender, EventArgs e)
        {
            OpenCompanyPDF();
        }


 
        private void titleLabel_Click(object sender, EventArgs e)
        {
            OpenCompanyPDF();

        }

        private void OpenCompanyPDF()
        {
            string pdfFolder = Path.Combine(Application.StartupPath, "PDFs");
            string pdfFileName = $"{CompanyID}.pdf";
            string pdfPath = Path.Combine(pdfFolder, pdfFileName);

            try
            {
                Process.Start(pdfPath);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PDF not found for the selected company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
