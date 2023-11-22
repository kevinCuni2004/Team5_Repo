using System;

namespace Citisoft
{
    partial class UserTabForm
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
            this.Back_Button = new System.Windows.Forms.Button();
            this.Help_Button = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.changePasswordPanel = new System.Windows.Forms.Panel();
            this.changePassButton = new System.Windows.Forms.Button();
            this.cancelPassChangeButton = new System.Windows.Forms.Button();
            this.confrimNewPassLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.confirmNewPassTextBox = new System.Windows.Forms.TextBox();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordTitle = new System.Windows.Forms.Label();
            this.changePasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(36, 24);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(55, 24);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(434, 24);
            this.Help_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(55, 24);
            this.Help_Button.TabIndex = 1;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLabel.Location = new System.Drawing.Point(103, 65);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(145, 24);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "<e-mail>";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameLabel.Location = new System.Drawing.Point(103, 108);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(145, 24);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "<first_name>";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fnameLabel.Click += new System.EventHandler(this.fnameLabel_Click);
            // 
            // lnameLabel
            // 
            this.lnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameLabel.Location = new System.Drawing.Point(103, 153);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(145, 24);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "<last_name>";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnameLabel.Click += new System.EventHandler(this.lnameLabel_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageLabel.Location = new System.Drawing.Point(103, 198);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(145, 24);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "<date_of_birth>";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ageLabel.Click += new System.EventHandler(this.ageLabel_Click);
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePasswordLabel.Location = new System.Drawing.Point(103, 240);
            this.changePasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(145, 24);
            this.changePasswordLabel.TabIndex = 6;
            this.changePasswordLabel.Text = "Change Password";
            this.changePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePasswordLabel.Click += new System.EventHandler(this.changePasswordLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Location = new System.Drawing.Point(288, 88);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(163, 176);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "<description>";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descTitleLabel
            // 
            this.descTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descTitleLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTitleLabel.Location = new System.Drawing.Point(288, 65);
            this.descTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descTitleLabel.Name = "descTitleLabel";
            this.descTitleLabel.Size = new System.Drawing.Size(163, 24);
            this.descTitleLabel.TabIndex = 8;
            this.descTitleLabel.Text = "Description";
            this.descTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descTitleLabel.Click += new System.EventHandler(this.descTitleLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(149, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(228, 42);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Citisoft";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.Controls.Add(this.changePassButton);
            this.changePasswordPanel.Controls.Add(this.cancelPassChangeButton);
            this.changePasswordPanel.Controls.Add(this.confrimNewPassLabel);
            this.changePasswordPanel.Controls.Add(this.newPasswordLabel);
            this.changePasswordPanel.Controls.Add(this.oldPasswordLabel);
            this.changePasswordPanel.Controls.Add(this.confirmNewPassTextBox);
            this.changePasswordPanel.Controls.Add(this.newPassTextBox);
            this.changePasswordPanel.Controls.Add(this.oldPassTextBox);
            this.changePasswordPanel.Controls.Add(this.changePasswordTitle);
            this.changePasswordPanel.Location = new System.Drawing.Point(103, 65);
            this.changePasswordPanel.Margin = new System.Windows.Forms.Padding(2);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(348, 199);
            this.changePasswordPanel.TabIndex = 10;
            this.changePasswordPanel.Visible = false;
            this.changePasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.changePasswordPanel_Paint);
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(160, 167);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(105, 23);
            this.changePassButton.TabIndex = 8;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.Location = new System.Drawing.Point(94, 167);
            this.cancelPassChangeButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelPassChangeButton.Name = "cancelPassChangeButton";
            this.cancelPassChangeButton.Size = new System.Drawing.Size(62, 23);
            this.cancelPassChangeButton.TabIndex = 7;
            this.cancelPassChangeButton.Text = "Cancel";
            this.cancelPassChangeButton.UseVisualStyleBackColor = true;
            this.cancelPassChangeButton.Click += new System.EventHandler(this.cancelPassChangeButton_Click);
            // 
            // confrimNewPassLabel
            // 
            this.confrimNewPassLabel.AutoSize = true;
            this.confrimNewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimNewPassLabel.Location = new System.Drawing.Point(4, 139);
            this.confrimNewPassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confrimNewPassLabel.Name = "confrimNewPassLabel";
            this.confrimNewPassLabel.Size = new System.Drawing.Size(152, 17);
            this.confrimNewPassLabel.TabIndex = 6;
            this.confrimNewPassLabel.Text = "Confrim New Password";
            this.confrimNewPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(56, 103);
            this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(100, 17);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "New Password";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(61, 70);
            this.oldPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(95, 17);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNewPassTextBox
            // 
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(160, 139);
            this.confirmNewPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.Size = new System.Drawing.Size(161, 20);
            this.confirmNewPassTextBox.TabIndex = 3;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(160, 103);
            this.newPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(161, 20);
            this.newPassTextBox.TabIndex = 2;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(160, 69);
            this.oldPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(161, 20);
            this.oldPassTextBox.TabIndex = 1;
            // 
            // changePasswordTitle
            // 
            this.changePasswordTitle.AutoSize = true;
            this.changePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTitle.Location = new System.Drawing.Point(87, 23);
            this.changePasswordTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changePasswordTitle.Name = "changePasswordTitle";
            this.changePasswordTitle.Size = new System.Drawing.Size(164, 24);
            this.changePasswordTitle.TabIndex = 0;
            this.changePasswordTitle.Text = "Change Password";
            this.changePasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.changePasswordPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descTitleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.Back_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserTabForm";
            this.Text = "UserTab";
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel changePasswordPanel;
        private System.Windows.Forms.Label changePasswordTitle;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox confirmNewPassTextBox;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.Label confrimNewPassLabel;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button cancelPassChangeButton;
    }
}