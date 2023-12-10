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
    public partial class HelpRequestForm : Form
    {
        //private DatabaseHelper _dbHelper;

        public HelpRequestForm()
        {
            InitializeComponent();
            //_dbHelper = new DatabaseHelper("path_to_your_Messages.db");
            LoadMessagesFromDatabase();
        }

        private void LoadMessagesFromDatabase()
        {
            listViewMessages.Items.Clear();
            //var messages = _dbHelper.GetAllMessages();
            //foreach (var (Message, Timestamp) in messages)
            //{
                //AddMessageToListView(Message, Timestamp);
            //}
        }

        private void AddMessageToListView(string message, string timestamp)
        {
            ListViewItem item = new ListViewItem(message);
            item.SubItems.Add(timestamp);
            listViewMessages.Items.Add(item);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedMessages();
        }

        private void DeleteSelectedMessages()
        {
            foreach (ListViewItem item in listViewMessages.CheckedItems)
            {
                string message = item.SubItems[0].Text;
                string timestamp = item.SubItems[1].Text;
                //_dbHelper.DeleteMessage(message, timestamp);
                listViewMessages.Items.Remove(item);
            }
        }

        private void ListViewMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewMessages.SelectedItems.Count > 0)
            {
                var message = listViewMessages.SelectedItems[0].SubItems[0].Text;
                var timestamp = listViewMessages.SelectedItems[0].SubItems[1].Text;
                MessageBox.Show("Message: " + message + "\nTimestamp: " + timestamp, "Message Details");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
