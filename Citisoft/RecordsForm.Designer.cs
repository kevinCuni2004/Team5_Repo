namespace Citisoft
{
    partial class RecordsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.indexLabel = new System.Windows.Forms.Label();
            this.company_Id1 = new System.Windows.Forms.Label();
            this.company_Id2 = new System.Windows.Forms.Label();
            this.company_Id3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.company_Id4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameButton
            // 
            this.usernameButton.Location = new System.Drawing.Point(12, 12);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(122, 44);
            this.usernameButton.TabIndex = 0;
            this.usernameButton.Text = "Username";
            this.usernameButton.UseVisualStyleBackColor = true;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 394);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 44);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(615, 50);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 33);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(770, 87);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 305);
            this.vScrollBar1.TabIndex = 3;
            // 
            // indexLabel
            // 
            this.indexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(48, 8);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(39, 16);
            this.indexLabel.TabIndex = 4;
            this.indexLabel.Text = "index";
            // 
            // company_Id1
            // 
            this.company_Id1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.company_Id1.AutoSize = true;
            this.company_Id1.Location = new System.Drawing.Point(20, 54);
            this.company_Id1.Name = "company_Id1";
            this.company_Id1.Size = new System.Drawing.Size(95, 16);
            this.company_Id1.TabIndex = 5;
            this.company_Id1.Text = "<company_id>";
            this.company_Id1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // company_Id2
            // 
            this.company_Id2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.company_Id2.AutoSize = true;
            this.company_Id2.Location = new System.Drawing.Point(20, 118);
            this.company_Id2.Name = "company_Id2";
            this.company_Id2.Size = new System.Drawing.Size(95, 16);
            this.company_Id2.TabIndex = 6;
            this.company_Id2.Text = "<company_id>";
            // 
            // company_Id3
            // 
            this.company_Id3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.company_Id3.AutoSize = true;
            this.company_Id3.Location = new System.Drawing.Point(20, 183);
            this.company_Id3.Name = "company_Id3";
            this.company_Id3.Size = new System.Drawing.Size(95, 16);
            this.company_Id3.TabIndex = 7;
            this.company_Id3.Text = "<company_id>";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Controls.Add(this.company_Id4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.indexLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.company_Id3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.company_Id1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.company_Id2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.4086F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.5914F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 274);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // company_Id4
            // 
            this.company_Id4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.company_Id4.AutoSize = true;
            this.company_Id4.Location = new System.Drawing.Point(20, 240);
            this.company_Id4.Name = "company_Id4";
            this.company_Id4.Size = new System.Drawing.Size(95, 16);
            this.company_Id4.TabIndex = 9;
            this.company_Id4.Text = "<company_id>";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(327, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 45);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Citisoft";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usernameButton);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label company_Id1;
        private System.Windows.Forms.Label company_Id2;
        private System.Windows.Forms.Label company_Id3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label company_Id4;
        private System.Windows.Forms.Label nameLabel;
    }
}