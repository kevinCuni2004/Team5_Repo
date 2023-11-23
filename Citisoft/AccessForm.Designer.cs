namespace Citisoft
{
    partial class AccessForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profile_Id1 = new System.Windows.Forms.Label();
            this.status_Id1 = new System.Windows.Forms.Label();
            this.username_Id1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameButton
            // 
            this.usernameButton.Location = new System.Drawing.Point(12, 12);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(123, 46);
            this.usernameButton.TabIndex = 0;
            this.usernameButton.Text = "Username";
            this.usernameButton.UseVisualStyleBackColor = true;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 395);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 43);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(586, 40);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(114, 50);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(764, 94);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(27, 282);
            this.vScrollBar1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.9604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel1.Controls.Add(this.username_Id1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.status_Id1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.profile_Id1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(127, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 67);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(303, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 45);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Citisoft";
            // 
            // profile_Id1
            // 
            this.profile_Id1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profile_Id1.AutoSize = true;
            this.profile_Id1.Location = new System.Drawing.Point(24, 25);
            this.profile_Id1.Name = "profile_Id1";
            this.profile_Id1.Size = new System.Drawing.Size(76, 16);
            this.profile_Id1.TabIndex = 6;
            this.profile_Id1.Text = "<profile_id>";
            // 
            // status_Id1
            // 
            this.status_Id1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status_Id1.AutoSize = true;
            this.status_Id1.Location = new System.Drawing.Point(141, 25);
            this.status_Id1.Name = "status_Id1";
            this.status_Id1.Size = new System.Drawing.Size(74, 16);
            this.status_Id1.TabIndex = 6;
            this.status_Id1.Text = "<status_id>";
            // 
            // username_Id1
            // 
            this.username_Id1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_Id1.AutoSize = true;
            this.username_Id1.Location = new System.Drawing.Point(353, 25);
            this.username_Id1.Name = "username_Id1";
            this.username_Id1.Size = new System.Drawing.Size(99, 16);
            this.username_Id1.TabIndex = 6;
            this.username_Id1.Text = "<username_id>";
            // 
            // AccessForm
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
            this.Name = "AccessForm";
            this.Text = "AccessForm";
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label username_Id1;
        private System.Windows.Forms.Label status_Id1;
        private System.Windows.Forms.Label profile_Id1;
    }
}