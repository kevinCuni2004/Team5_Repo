﻿using System;
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
            //WelcomeForm welcomeForm = new WelcomeForm();
            //Application.Run(new WelcomeForm());
            //RecordsForm accessForm = new RecordsForm();
            //Application.Run(new RecordsForm());
            SearchForm searchForm = new SearchForm();
            Application.Run(searchForm);
        }
    }
}
