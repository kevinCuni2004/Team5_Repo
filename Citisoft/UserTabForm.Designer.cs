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
            this.updateInfoLabel = new System.Windows.Forms.Label();
            this.changeFNamePanel = new System.Windows.Forms.Panel();
            this.changeFNameButton = new System.Windows.Forms.Button();
            this.cancelFNameChange = new System.Windows.Forms.Button();
            this.confrimFNameLabel = new System.Windows.Forms.Label();
            this.newFNameLabel = new System.Windows.Forms.Label();
            this.confrimFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameLabel = new System.Windows.Forms.Label();
            this.changePasswordPanel.SuspendLayout();
            this.changeFNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(54, 37);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(82, 37);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(651, 37);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(82, 37);
            this.Help_Button.TabIndex = 1;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLabel.Location = new System.Drawing.Point(54, 100);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(316, 36);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "<e-mail>";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameLabel.Location = new System.Drawing.Point(100, 166);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(216, 36);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "<first_name>";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fnameLabel.Click += new System.EventHandler(this.fnameLabel_Click);
            // 
            // lnameLabel
            // 
            this.lnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameLabel.Location = new System.Drawing.Point(100, 233);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(216, 36);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "<last_name>";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnameLabel.Click += new System.EventHandler(this.lnameLabel_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageLabel.Location = new System.Drawing.Point(100, 302);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(216, 36);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "<date_of_birth>";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ageLabel.Click += new System.EventHandler(this.ageLabel_Click);
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePasswordLabel.Location = new System.Drawing.Point(100, 369);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(216, 36);
            this.changePasswordLabel.TabIndex = 6;
            this.changePasswordLabel.Text = "Change Password";
            this.changePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePasswordLabel.Click += new System.EventHandler(this.changePasswordLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Location = new System.Drawing.Point(432, 135);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(244, 270);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "<description>";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descTitleLabel
            // 
            this.descTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descTitleLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTitleLabel.Location = new System.Drawing.Point(432, 100);
            this.descTitleLabel.Name = "descTitleLabel";
            this.descTitleLabel.Size = new System.Drawing.Size(244, 36);
            this.descTitleLabel.TabIndex = 8;
            this.descTitleLabel.Text = "Description";
            this.descTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descTitleLabel.Click += new System.EventHandler(this.descTitleLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(224, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(342, 65);
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
            this.changePasswordPanel.Location = new System.Drawing.Point(736, 99);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(522, 306);
            this.changePasswordPanel.TabIndex = 10;
            this.changePasswordPanel.Visible = false;
            this.changePasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.changePasswordPanel_Paint);
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(240, 257);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(158, 35);
            this.changePassButton.TabIndex = 8;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.Location = new System.Drawing.Point(141, 257);
            this.cancelPassChangeButton.Name = "cancelPassChangeButton";
            this.cancelPassChangeButton.Size = new System.Drawing.Size(93, 35);
            this.cancelPassChangeButton.TabIndex = 7;
            this.cancelPassChangeButton.Text = "Cancel";
            this.cancelPassChangeButton.UseVisualStyleBackColor = true;
            this.cancelPassChangeButton.Click += new System.EventHandler(this.cancelPassChangeButton_Click);
            // 
            // confrimNewPassLabel
            // 
            this.confrimNewPassLabel.AutoSize = true;
            this.confrimNewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimNewPassLabel.Location = new System.Drawing.Point(6, 214);
            this.confrimNewPassLabel.Name = "confrimNewPassLabel";
            this.confrimNewPassLabel.Size = new System.Drawing.Size(215, 25);
            this.confrimNewPassLabel.TabIndex = 6;
            this.confrimNewPassLabel.Text = "Confrim New Password";
            this.confrimNewPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(84, 158);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(142, 25);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "New Password";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(92, 108);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(134, 25);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNewPassTextBox
            // 
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(240, 214);
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.confirmNewPassTextBox.TabIndex = 3;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(240, 158);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.newPassTextBox.TabIndex = 2;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(240, 106);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.oldPassTextBox.TabIndex = 1;
            // 
            // changePasswordTitle
            // 
            this.changePasswordTitle.AutoSize = true;
            this.changePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTitle.Location = new System.Drawing.Point(130, 35);
            this.changePasswordTitle.Name = "changePasswordTitle";
            this.changePasswordTitle.Size = new System.Drawing.Size(245, 32);
            this.changePasswordTitle.TabIndex = 0;
            this.changePasswordTitle.Text = "Change Password";
            this.changePasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateInfoLabel
            // 
            this.updateInfoLabel.AutoSize = true;
            this.updateInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.updateInfoLabel.Location = new System.Drawing.Point(281, 68);
            this.updateInfoLabel.Name = "updateInfoLabel";
            this.updateInfoLabel.Size = new System.Drawing.Size(228, 20);
            this.updateInfoLabel.TabIndex = 11;
            this.updateInfoLabel.Text = "Please update your information";
            // 
            // changeFNamePanel
            // 
            this.changeFNamePanel.Controls.Add(this.changeFNameButton);
            this.changeFNamePanel.Controls.Add(this.cancelFNameChange);
            this.changeFNamePanel.Controls.Add(this.confrimFNameLabel);
            this.changeFNamePanel.Controls.Add(this.newFNameLabel);
            this.changeFNamePanel.Controls.Add(this.confrimFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameLabel);
            this.changeFNamePanel.Location = new System.Drawing.Point(682, 166);
            this.changeFNamePanel.Name = "changeFNamePanel";
            this.changeFNamePanel.Size = new System.Drawing.Size(522, 306);
            this.changeFNamePanel.TabIndex = 11;
            this.changeFNamePanel.Visible = false;
            // 
            // changeFNameButton
            // 
            this.changeFNameButton.Location = new System.Drawing.Point(240, 246);
            this.changeFNameButton.Name = "changeFNameButton";
            this.changeFNameButton.Size = new System.Drawing.Size(158, 35);
            this.changeFNameButton.TabIndex = 8;
            this.changeFNameButton.Text = "Change First Name";
            this.changeFNameButton.UseVisualStyleBackColor = true;
            this.changeFNameButton.Click += new System.EventHandler(this.changeFNameButton_Click);
            // 
            // cancelFNameChange
            // 
            this.cancelFNameChange.Location = new System.Drawing.Point(141, 246);
            this.cancelFNameChange.Name = "cancelFNameChange";
            this.cancelFNameChange.Size = new System.Drawing.Size(93, 35);
            this.cancelFNameChange.TabIndex = 7;
            this.cancelFNameChange.Text = "Cancel";
            this.cancelFNameChange.UseVisualStyleBackColor = true;
            this.cancelFNameChange.Click += new System.EventHandler(this.cancelFNameChange_Click);
            // 
            // confrimFNameLabel
            // 
            this.confrimFNameLabel.AutoSize = true;
            this.confrimFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimFNameLabel.Location = new System.Drawing.Point(63, 171);
            this.confrimFNameLabel.Name = "confrimFNameLabel";
            this.confrimFNameLabel.Size = new System.Drawing.Size(137, 25);
            this.confrimFNameLabel.TabIndex = 5;
            this.confrimFNameLabel.Text = "Confirm Name";
            this.confrimFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newFNameLabel
            // 
            this.newFNameLabel.AutoSize = true;
            this.newFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFNameLabel.Location = new System.Drawing.Point(92, 122);
            this.newFNameLabel.Name = "newFNameLabel";
            this.newFNameLabel.Size = new System.Drawing.Size(106, 25);
            this.newFNameLabel.TabIndex = 4;
            this.newFNameLabel.Text = "First Name";
            this.newFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confrimFNameTextBox
            // 
            this.confrimFNameTextBox.Location = new System.Drawing.Point(210, 170);
            this.confrimFNameTextBox.Name = "confrimFNameTextBox";
            this.confrimFNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.confrimFNameTextBox.TabIndex = 2;
            // 
            // changeFNameTextBox
            // 
            this.changeFNameTextBox.Location = new System.Drawing.Point(210, 121);
            this.changeFNameTextBox.Name = "changeFNameTextBox";
            this.changeFNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.changeFNameTextBox.TabIndex = 1;
            // 
            // changeFNameLabel
            // 
            this.changeFNameLabel.AutoSize = true;
            this.changeFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFNameLabel.Location = new System.Drawing.Point(130, 45);
            this.changeFNameLabel.Name = "changeFNameLabel";
            this.changeFNameLabel.Size = new System.Drawing.Size(258, 32);
            this.changeFNameLabel.TabIndex = 0;
            this.changeFNameLabel.Text = "Change First Name";
            this.changeFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.changeFNamePanel);
            this.Controls.Add(this.updateInfoLabel);
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
            this.Name = "UserTabForm";
            this.Text = "UserTab";
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.changeFNamePanel.ResumeLayout(false);
            this.changeFNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label updateInfoLabel;
        private System.Windows.Forms.Panel changeFNamePanel;
        private System.Windows.Forms.Button changeFNameButton;
        private System.Windows.Forms.Button cancelFNameChange;
        private System.Windows.Forms.Label confrimFNameLabel;
        private System.Windows.Forms.Label newFNameLabel;
        private System.Windows.Forms.TextBox confrimFNameTextBox;
        private System.Windows.Forms.TextBox changeFNameTextBox;
        private System.Windows.Forms.Label changeFNameLabel;
    }
}