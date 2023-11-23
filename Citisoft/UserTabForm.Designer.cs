﻿using System;

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
            this.dobLabel = new System.Windows.Forms.Label();
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
            this.changeFNamePanel = new System.Windows.Forms.Panel();
            this.changeFNameButton = new System.Windows.Forms.Button();
            this.cancelFNameChange = new System.Windows.Forms.Button();
            this.confrimFNameLabel = new System.Windows.Forms.Label();
            this.newFNameLabel = new System.Windows.Forms.Label();
            this.confirmFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameLabel = new System.Windows.Forms.Label();
            this.changeLNamePanel = new System.Windows.Forms.Panel();
            this.changeLNameButton = new System.Windows.Forms.Button();
            this.cancelLNameButton = new System.Windows.Forms.Button();
            this.confrimLNameLabel = new System.Windows.Forms.Label();
            this.newLNameLabel = new System.Windows.Forms.Label();
            this.confirmLNameTextBox = new System.Windows.Forms.TextBox();
            this.changeLNameTextBox = new System.Windows.Forms.TextBox();
            this.changeLNameLabel = new System.Windows.Forms.Label();
            this.changeDescPanel = new System.Windows.Forms.Panel();
            this.changeDescTextBox = new System.Windows.Forms.TextBox();
            this.changeDescButton = new System.Windows.Forms.Button();
            this.cancelDescButton = new System.Windows.Forms.Button();
            this.changeDescLabel = new System.Windows.Forms.Label();
            this.updateInfoLabel = new System.Windows.Forms.Label();
            this.changePasswordPanel.SuspendLayout();
            this.changeFNamePanel.SuspendLayout();
            this.changeLNamePanel.SuspendLayout();
            this.changeDescPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(54, 38);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(82, 38);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(651, 38);
            this.Help_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(82, 38);
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
            this.lnameLabel.Location = new System.Drawing.Point(100, 232);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(216, 36);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "<last_name>";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnameLabel.Click += new System.EventHandler(this.lnameLabel_Click);
            // 
            // dobLabel
            // 
            this.dobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dobLabel.Location = new System.Drawing.Point(100, 302);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(216, 36);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "<date_of_birth>";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dobLabel.Click += new System.EventHandler(this.dobLabel_Click);
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
            this.descTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.changePasswordPanel.Location = new System.Drawing.Point(737, 84);
            this.changePasswordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(679, 306);
            this.changePasswordPanel.TabIndex = 10;
            this.changePasswordPanel.Visible = false;
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(332, 258);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(158, 35);
            this.changePassButton.TabIndex = 8;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.Location = new System.Drawing.Point(210, 258);
            this.cancelPassChangeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.confrimNewPassLabel.Location = new System.Drawing.Point(93, 213);
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
            this.newPasswordLabel.Location = new System.Drawing.Point(165, 156);
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
            this.oldPasswordLabel.Location = new System.Drawing.Point(173, 110);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(134, 25);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNewPassTextBox
            // 
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(333, 214);
            this.confirmNewPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.confirmNewPassTextBox.TabIndex = 3;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(333, 158);
            this.newPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.newPassTextBox.TabIndex = 2;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(333, 109);
            this.oldPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.oldPassTextBox.TabIndex = 1;
            // 
            // changePasswordTitle
            // 
            this.changePasswordTitle.AutoSize = true;
            this.changePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTitle.Location = new System.Drawing.Point(216, 34);
            this.changePasswordTitle.Name = "changePasswordTitle";
            this.changePasswordTitle.Size = new System.Drawing.Size(245, 32);
            this.changePasswordTitle.TabIndex = 0;
            this.changePasswordTitle.Text = "Change Password";
            this.changePasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeFNamePanel
            // 
            this.changeFNamePanel.Controls.Add(this.changeFNameButton);
            this.changeFNamePanel.Controls.Add(this.cancelFNameChange);
            this.changeFNamePanel.Controls.Add(this.confrimFNameLabel);
            this.changeFNamePanel.Controls.Add(this.newFNameLabel);
            this.changeFNamePanel.Controls.Add(this.confirmFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameLabel);
            this.changeFNamePanel.Location = new System.Drawing.Point(23, 29);
            this.changeFNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNamePanel.Name = "changeFNamePanel";
            this.changeFNamePanel.Size = new System.Drawing.Size(678, 306);
            this.changeFNamePanel.TabIndex = 11;
            this.changeFNamePanel.Visible = false;
            // 
            // changeFNameButton
            // 
            this.changeFNameButton.Location = new System.Drawing.Point(317, 246);
            this.changeFNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNameButton.Name = "changeFNameButton";
            this.changeFNameButton.Size = new System.Drawing.Size(158, 35);
            this.changeFNameButton.TabIndex = 8;
            this.changeFNameButton.Text = "Change First Name";
            this.changeFNameButton.UseVisualStyleBackColor = true;
            this.changeFNameButton.Click += new System.EventHandler(this.changeFNameButton_Click);
            // 
            // cancelFNameChange
            // 
            this.cancelFNameChange.Location = new System.Drawing.Point(196, 246);
            this.cancelFNameChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.confrimFNameLabel.Location = new System.Drawing.Point(141, 171);
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
            this.newFNameLabel.Location = new System.Drawing.Point(176, 122);
            this.newFNameLabel.Name = "newFNameLabel";
            this.newFNameLabel.Size = new System.Drawing.Size(106, 25);
            this.newFNameLabel.TabIndex = 4;
            this.newFNameLabel.Text = "First Name";
            this.newFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmFNameTextBox
            // 
            this.confirmFNameTextBox.Location = new System.Drawing.Point(313, 170);
            this.confirmFNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmFNameTextBox.Name = "confirmFNameTextBox";
            this.confirmFNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.confirmFNameTextBox.TabIndex = 2;
            // 
            // changeFNameTextBox
            // 
            this.changeFNameTextBox.Location = new System.Drawing.Point(313, 121);
            this.changeFNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNameTextBox.Name = "changeFNameTextBox";
            this.changeFNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.changeFNameTextBox.TabIndex = 1;
            // 
            // changeFNameLabel
            // 
            this.changeFNameLabel.AutoSize = true;
            this.changeFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFNameLabel.Location = new System.Drawing.Point(207, 45);
            this.changeFNameLabel.Name = "changeFNameLabel";
            this.changeFNameLabel.Size = new System.Drawing.Size(258, 32);
            this.changeFNameLabel.TabIndex = 0;
            this.changeFNameLabel.Text = "Change First Name";
            this.changeFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLNamePanel
            // 
            this.changeLNamePanel.Controls.Add(this.changeFNamePanel);
            this.changeLNamePanel.Controls.Add(this.changeLNameButton);
            this.changeLNamePanel.Controls.Add(this.cancelLNameButton);
            this.changeLNamePanel.Controls.Add(this.confrimLNameLabel);
            this.changeLNamePanel.Controls.Add(this.newLNameLabel);
            this.changeLNamePanel.Controls.Add(this.confirmLNameTextBox);
            this.changeLNamePanel.Controls.Add(this.changeLNameTextBox);
            this.changeLNamePanel.Controls.Add(this.changeLNameLabel);
            this.changeLNamePanel.Location = new System.Drawing.Point(23, 24);
            this.changeLNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNamePanel.Name = "changeLNamePanel";
            this.changeLNamePanel.Size = new System.Drawing.Size(679, 306);
            this.changeLNamePanel.TabIndex = 12;
            this.changeLNamePanel.Visible = false;
            // 
            // changeLNameButton
            // 
            this.changeLNameButton.Location = new System.Drawing.Point(332, 246);
            this.changeLNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNameButton.Name = "changeLNameButton";
            this.changeLNameButton.Size = new System.Drawing.Size(158, 35);
            this.changeLNameButton.TabIndex = 8;
            this.changeLNameButton.Text = "Change Last Name";
            this.changeLNameButton.UseVisualStyleBackColor = true;
            this.changeLNameButton.Click += new System.EventHandler(this.changeLNameButton_Click);
            // 
            // cancelLNameButton
            // 
            this.cancelLNameButton.Location = new System.Drawing.Point(217, 246);
            this.cancelLNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelLNameButton.Name = "cancelLNameButton";
            this.cancelLNameButton.Size = new System.Drawing.Size(93, 35);
            this.cancelLNameButton.TabIndex = 7;
            this.cancelLNameButton.Text = "Cancel";
            this.cancelLNameButton.UseVisualStyleBackColor = true;
            this.cancelLNameButton.Click += new System.EventHandler(this.cancelLNameButton_Click);
            // 
            // confrimLNameLabel
            // 
            this.confrimLNameLabel.AutoSize = true;
            this.confrimLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimLNameLabel.Location = new System.Drawing.Point(147, 171);
            this.confrimLNameLabel.Name = "confrimLNameLabel";
            this.confrimLNameLabel.Size = new System.Drawing.Size(137, 25);
            this.confrimLNameLabel.TabIndex = 5;
            this.confrimLNameLabel.Text = "Confirm Name";
            this.confrimLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newLNameLabel
            // 
            this.newLNameLabel.AutoSize = true;
            this.newLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLNameLabel.Location = new System.Drawing.Point(178, 122);
            this.newLNameLabel.Name = "newLNameLabel";
            this.newLNameLabel.Size = new System.Drawing.Size(106, 25);
            this.newLNameLabel.TabIndex = 4;
            this.newLNameLabel.Text = "Last Name";
            this.newLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmLNameTextBox
            // 
            this.confirmLNameTextBox.Location = new System.Drawing.Point(315, 170);
            this.confirmLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmLNameTextBox.Name = "confirmLNameTextBox";
            this.confirmLNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.confirmLNameTextBox.TabIndex = 2;
            // 
            // changeLNameTextBox
            // 
            this.changeLNameTextBox.Location = new System.Drawing.Point(316, 121);
            this.changeLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNameTextBox.Name = "changeLNameTextBox";
            this.changeLNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.changeLNameTextBox.TabIndex = 1;
            // 
            // changeLNameLabel
            // 
            this.changeLNameLabel.AutoSize = true;
            this.changeLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLNameLabel.Location = new System.Drawing.Point(208, 45);
            this.changeLNameLabel.Name = "changeLNameLabel";
            this.changeLNameLabel.Size = new System.Drawing.Size(257, 32);
            this.changeLNameLabel.TabIndex = 0;
            this.changeLNameLabel.Text = "Change Last Name";
            this.changeLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDescPanel
            // 
            this.changeDescPanel.Controls.Add(this.changeDescTextBox);
            this.changeDescPanel.Controls.Add(this.changeLNamePanel);
            this.changeDescPanel.Controls.Add(this.changeDescButton);
            this.changeDescPanel.Controls.Add(this.cancelDescButton);
            this.changeDescPanel.Controls.Add(this.changeDescLabel);
            this.changeDescPanel.Location = new System.Drawing.Point(762, 197);
            this.changeDescPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescPanel.Name = "changeDescPanel";
            this.changeDescPanel.Size = new System.Drawing.Size(677, 304);
            this.changeDescPanel.TabIndex = 13;
            this.changeDescPanel.Visible = false;
            // 
            // changeDescTextBox
            // 
            this.changeDescTextBox.Location = new System.Drawing.Point(55, 59);
            this.changeDescTextBox.Multiline = true;
            this.changeDescTextBox.Name = "changeDescTextBox";
            this.changeDescTextBox.Size = new System.Drawing.Size(566, 182);
            this.changeDescTextBox.TabIndex = 9;
            // 
            // changeDescButton
            // 
            this.changeDescButton.Location = new System.Drawing.Point(353, 244);
            this.changeDescButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescButton.Name = "changeDescButton";
            this.changeDescButton.Size = new System.Drawing.Size(158, 35);
            this.changeDescButton.TabIndex = 8;
            this.changeDescButton.Text = "Change Description";
            this.changeDescButton.UseVisualStyleBackColor = true;
            this.changeDescButton.Click += new System.EventHandler(this.changeDescButton_Click);
            // 
            // cancelDescButton
            // 
            this.cancelDescButton.Location = new System.Drawing.Point(245, 246);
            this.cancelDescButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelDescButton.Name = "cancelDescButton";
            this.cancelDescButton.Size = new System.Drawing.Size(93, 35);
            this.cancelDescButton.TabIndex = 7;
            this.cancelDescButton.Text = "Cancel";
            this.cancelDescButton.UseVisualStyleBackColor = true;
            this.cancelDescButton.Click += new System.EventHandler(this.cancelDescButton_Click);
            // 
            // changeDescLabel
            // 
            this.changeDescLabel.AutoSize = true;
            this.changeDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDescLabel.Location = new System.Drawing.Point(210, 19);
            this.changeDescLabel.Name = "changeDescLabel";
            this.changeDescLabel.Size = new System.Drawing.Size(264, 32);
            this.changeDescLabel.TabIndex = 0;
            this.changeDescLabel.Text = "Change Description";
            this.changeDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // UserTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.changeDescPanel);
            this.Controls.Add(this.updateInfoLabel);
            this.Controls.Add(this.changePasswordPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descTitleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.Back_Button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserTabForm";
            this.Text = "UserTab";
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.changeFNamePanel.ResumeLayout(false);
            this.changeFNamePanel.PerformLayout();
            this.changeLNamePanel.ResumeLayout(false);
            this.changeLNamePanel.PerformLayout();
            this.changeDescPanel.ResumeLayout(false);
            this.changeDescPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label dobLabel;
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
        private System.Windows.Forms.TextBox confirmFNameTextBox;
        private System.Windows.Forms.TextBox changeFNameTextBox;
        private System.Windows.Forms.Label changeFNameLabel;
        private System.Windows.Forms.Panel changeLNamePanel;
        private System.Windows.Forms.Button changeLNameButton;
        private System.Windows.Forms.Button cancelLNameButton;
        private System.Windows.Forms.Label confrimLNameLabel;
        private System.Windows.Forms.Label newLNameLabel;
        private System.Windows.Forms.TextBox confirmLNameTextBox;
        private System.Windows.Forms.TextBox changeLNameTextBox;
        private System.Windows.Forms.Label changeLNameLabel;
        private System.Windows.Forms.Panel changeDescPanel;
        private System.Windows.Forms.Button changeDescButton;
        private System.Windows.Forms.Button cancelDescButton;
        private System.Windows.Forms.Label changeDescLabel;
        private System.Windows.Forms.TextBox changeDescTextBox;
    }
}