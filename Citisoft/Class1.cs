using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citisoft
{
    class program 
    {
        [STAThread]

        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SignUpForm signUpForm = new SignUpForm();
            Application.Run(signUpForm);
        }
        }
}
