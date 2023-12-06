using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Citisoft
{
    partial class Form2
    {
        private IContainer components = null;
        private ListView listViewMessages;
        private Button buttonDelete;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listViewMessages = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listViewMessages
            // 
            listViewMessages.CheckBoxes = true;
            listViewMessages.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewMessages.FullRowSelect = true;
            listViewMessages.GridLines = true;
            listViewMessages.Location = new Point(12, 140);
            listViewMessages.Name = "listViewMessages";
            listViewMessages.Size = new Size(1086, 379);
            listViewMessages.TabIndex = 0;
            listViewMessages.UseCompatibleStateImageBehavior = false;
            listViewMessages.View = View.Details;
            listViewMessages.SelectedIndexChanged += ListViewMessages_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Message";
            columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Timestamp";
            columnHeader2.Width = 276;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(12, 525);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(1086, 44);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete Selected Messages";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 53);
            label1.TabIndex = 2;
            label1.Text = "Help Requests ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(434, 27);
            label2.TabIndex = 3;
            label2.Text = "Only admin can read and delete the request";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(37, 23);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 601);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(listViewMessages);
            Name = "Form2";
            Text = "Messages";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Button button1;
    }
}