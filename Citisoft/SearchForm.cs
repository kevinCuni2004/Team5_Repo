using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citisoft;

namespace Citisoft
{
    public partial class SearchForm : Form
    {
        private Search search;
        public Button usernameButton;
        public Button helpButton;
        public TextBox searchTextBox;
        public SearchForm(Search search)
        {
            InitializeComponent();
            search = new Search();
        }

        private void InitializeComponent()
        {
            this.usernameButton = new System.Windows.Forms.Button();
            this.usernameButton.Location = new System.Drawing.Point(199, 116);
            this.usernameButton.Size = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.usernameButton);
        }
    }
}
