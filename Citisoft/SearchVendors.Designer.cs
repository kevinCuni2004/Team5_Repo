namespace Citisoft
{
    partial class SearchVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVendors));
            this.usernameButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.termsOfUseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameButton
            // 
            this.usernameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.usernameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.usernameButton.FlatAppearance.BorderSize = 2;
            this.usernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameButton.Location = new System.Drawing.Point(25, 16);
            this.usernameButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(144, 76);
            this.usernameButton.TabIndex = 0;
            this.usernameButton.Text = "Username";
            this.usernameButton.UseVisualStyleBackColor = false;
            this.usernameButton.Click += new System.EventHandler(this.usernameButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.helpButton.FlatAppearance.BorderSize = 2;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(1103, 9);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(144, 76);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(25, 553);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(144, 76);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultsLabel.Location = new System.Drawing.Point(554, 117);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(127, 38);
            this.resultsLabel.TabIndex = 6;
            this.resultsLabel.Text = "Results";
            // 
            // termsOfUseLinkLabel
            // 
            this.termsOfUseLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.termsOfUseLinkLabel.AutoSize = true;
            this.termsOfUseLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termsOfUseLinkLabel.Location = new System.Drawing.Point(442, 593);
            this.termsOfUseLinkLabel.Name = "termsOfUseLinkLabel";
            this.termsOfUseLinkLabel.Size = new System.Drawing.Size(375, 32);
            this.termsOfUseLinkLabel.TabIndex = 7;
            this.termsOfUseLinkLabel.TabStop = true;
            this.termsOfUseLinkLabel.Text = "Terms Of Use  Privacy policy";
            this.termsOfUseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.termsOfUseLinkLabel_LinkClicked);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vScrollBar1.Location = new System.Drawing.Point(1159, 170);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 381);
            this.vScrollBar1.TabIndex = 20;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(137, 196);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(980, 302);
            this.flowLayoutPanel.TabIndex = 22;
            // 
            // SearchVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1280, 650);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.termsOfUseLinkLabel);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.usernameButton);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SearchVendors";
            this.Text = "SearchVendors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.LinkLabel termsOfUseLinkLabel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}