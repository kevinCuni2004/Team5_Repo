using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft
{
    public partial class TermsOfUsecs : Form
    {
        public TermsOfUsecs()
        {
            InitializeComponent();
        }

        private void PDFButton_Click(object sender, EventArgs e)
        {
            string filename = "TermsOfUse.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
