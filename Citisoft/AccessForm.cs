using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Citisoft
{
            
    public partial class AccessForm : Form
    {
        private FlowLayoutPanel flowLayoutPanel;
        private DBConnection dBConnection;
        private Profile User;

        public AccessForm()
        {
            InitializeComponent();
            //InitializeDynamicControls();
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            //--go to usertab form--//

            //UserTabForm usertabForm = new UserTabForm();
            //usertabForm.Show();
            //this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //--go to admin home page form--//
            //--we don't have now so it won't work--//

            //AdminHomePage adminhomepage = new AdminHomePage();
            //adminhomepage.Show();
            //this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //--Edit button disapppears. Cancel/Confirm buttons arrears--//
            editButton.Visible = false;
            cancelButton.Visible = true;
            confirmButton.Visible = true;
            this.usernameIdTextBox.ReadOnly = false;
            this.profileIdTextBox.ReadOnly = false;
            this.statusIdTextBox.ReadOnly = false;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //--Привести в изначальную форму--//
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            editButton.Visible = true; 
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            
            cancelButton.Visible = false;
            confirmButton.Visible = false;
            editButton.Visible = true;
            string oneToZeroText = statusIdTextBox.Text;
            if(int.TryParse(oneToZeroText,out int inputValue) && inputValue >= 0 && inputValue <= 1)
            {
                //--Преобразовать в стринг--//
                User.Access = oneToZeroText;
                string query = "UPDATE [Profile] SET [access]=@access WHERE [e-mail]=@email;";
                dBConnection = DBConnection.getInstance();
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@access", User.Access);
            }
            else
            {
                statusValidation
            }
            //--Сохранить измененения в базу данных--//
            //--То что написано должно измениться в форме--//
            //--Проверка на правильность ввода(ИНТ-статус и профиль айди, СТР-ник)--//
        }

        private void AccessForm_Load(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //
        }
    }
}
