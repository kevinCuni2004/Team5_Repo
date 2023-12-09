//using AxAcroPDFLib;
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
//using Apitron.PDF.Rasterizer;
//using Apitron.PDF.Rasterizer.Configuration;
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

            string pdfFile = @"C:\Users\SAM LEADER\Desktop\TermsOfUse.pdf";
            try
            {
                Process.Start(pdfFile);
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

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void TermsOfUseForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"C:\Users\SAM LEADER\Desktop\TermsOfUse.pdf", FileMode.Open))
            {
                //Document document = new Document(fs);
                //for (int i = 0; i < document.Pages.Count; i++)
                //{
                    //Page page = document.Pages[i];
                    //using (Bitmap bitmap = page.Render((int)page.Width, (int)page.Height, new RenderingSettings()))
                    //{
                      //  bitmap.Save(string.Format("{0}.bmp", i), ImageFormat.Bmp);
                    //}
                //}
            }
        }
    }
}
