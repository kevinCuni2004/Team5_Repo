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
    public partial class CompanyUserControl : UserControl
    {
        public CompanyUserControl(string companyName, string companyWebsite)
        {
            InitializeComponent();
            InitializeControl(companyName, companyWebsite);
        }

        private void InitializeControl(string companyName, string companyWebsite)
        {
            titleLabel.Text = companyName;
            websiteLabel.Text = companyWebsite;
        }

        private void websiteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
