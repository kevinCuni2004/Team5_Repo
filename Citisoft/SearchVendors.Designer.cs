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
            this.usernameButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.termsOfUseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.company_Name_TextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameButton
            // 
            this.usernameButton.Location = new System.Drawing.Point(12, 12);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Size = new System.Drawing.Size(127, 55);
            this.usernameButton.TabIndex = 0;
            this.usernameButton.Text = "Username";
            this.usernameButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(661, 18);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(115, 49);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(114, 41);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(521, 350);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(107, 41);
            this.previousPageButton.TabIndex = 3;
            this.previousPageButton.Text = "previous page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(634, 350);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(108, 41);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.Text = "next page";
            this.nextPageButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(298, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 45);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Citisoft";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsLabel.Location = new System.Drawing.Point(322, 85);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(109, 32);
            this.resultsLabel.TabIndex = 6;
            this.resultsLabel.Text = "Results";
            // 
            // termsOfUseLinkLabel
            // 
            this.termsOfUseLinkLabel.AutoSize = true;
            this.termsOfUseLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termsOfUseLinkLabel.Location = new System.Drawing.Point(239, 15);
            this.termsOfUseLinkLabel.Name = "termsOfUseLinkLabel";
            this.termsOfUseLinkLabel.Size = new System.Drawing.Size(321, 29);
            this.termsOfUseLinkLabel.TabIndex = 7;
            this.termsOfUseLinkLabel.TabStop = true;
            this.termsOfUseLinkLabel.Text = "Terms Of Use  Privacy policy";
            // 
            // company_Name_TextBox
            // 
            this.company_Name_TextBox.Location = new System.Drawing.Point(50, 141);
            this.company_Name_TextBox.Name = "company_Name_TextBox";
            this.company_Name_TextBox.Size = new System.Drawing.Size(100, 22);
            this.company_Name_TextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(50, 169);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.termsOfUseLinkLabel);
            this.panel1.Location = new System.Drawing.Point(-2, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 58);
            this.panel1.TabIndex = 10;
            // 
            // SearchVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.company_Name_TextBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.usernameButton);
            this.Name = "SearchVendors";
            this.Text = "SearchVendors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usernameButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.LinkLabel termsOfUseLinkLabel;
        private System.Windows.Forms.TextBox company_Name_TextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}