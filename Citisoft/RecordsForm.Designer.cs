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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dataRecords = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameButton
            // 
            this.usernameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernameButton.Location = new System.Drawing.Point(64, 75);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(93, 50);
            this.usernameButton.TabIndex = 0;
            this.usernameButton.Text = "Username";
            this.usernameButton.UseVisualStyleBackColor = false;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Location = new System.Drawing.Point(50, 383);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 45);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.Location = new System.Drawing.Point(562, 84);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 33);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(825, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 45);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Citisoft";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataRecords
            // 
            this.dataRecords.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecords.Location = new System.Drawing.Point(115, 134);
            this.dataRecords.Name = "dataRecords";
            this.dataRecords.RowHeadersWidth = 51;
            this.dataRecords.RowTemplate.Height = 24;
            this.dataRecords.Size = new System.Drawing.Size(535, 236);
            this.dataRecords.TabIndex = 10;
            this.dataRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRecords_CellContentClick);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelButton.Location = new System.Drawing.Point(486, 84);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 33);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.confirmButton.Location = new System.Drawing.Point(599, 84);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(93, 33);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(277, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-18, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(806, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-3, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 116);
            this.panel1.TabIndex = 19;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(762, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataRecords);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.usernameButton);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView dataRecords;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}