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
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Citisoft
{
    public partial class TermsOfUseForm : Form
    {
        public TermsOfUseForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PDFButton_Click(object sender, EventArgs e)
        {

            string pdfFolder = Path.Combine(Application.StartupPath, "PDFs");
            string pdfFileName = "TermsOfUse.pdf";
            string pdfPath = Path.Combine(pdfFolder, pdfFileName);
            try
            {
                Process.Start(pdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can not open PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TermsOfUseForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"C:\Users\SAM LEADER\Desktop\TermsOfUse.pdf", FileMode.Open))
            {
               
            }
        }
    }
}
