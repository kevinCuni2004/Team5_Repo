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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTabForm));
            this.emailLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descTitleLabel = new System.Windows.Forms.Label();
            this.updateInfoLabel = new System.Windows.Forms.Label();
            this.changeDOBTab = new System.Windows.Forms.TabPage();
            this.changeDOBPanel = new System.Windows.Forms.Panel();
            this.DOB_Year = new System.Windows.Forms.NumericUpDown();
            this.DOB_Month = new System.Windows.Forms.NumericUpDown();
            this.DOB_Day = new System.Windows.Forms.NumericUpDown();
            this.changeDOBButton = new System.Windows.Forms.Button();
            this.cancelDOBButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeDOBLabel = new System.Windows.Forms.Label();
            this.changePasswordTab = new System.Windows.Forms.TabPage();
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
            this.changeLNameTab = new System.Windows.Forms.TabPage();
            this.changeLNamePanel = new System.Windows.Forms.Panel();
            this.changeLNameButton = new System.Windows.Forms.Button();
            this.cancelLNameButton = new System.Windows.Forms.Button();
            this.confrimLNameLabel = new System.Windows.Forms.Label();
            this.newLNameLabel = new System.Windows.Forms.Label();
            this.confirmLNameTextBox = new System.Windows.Forms.TextBox();
            this.changeLNameTextBox = new System.Windows.Forms.TextBox();
            this.changeLNameLabel = new System.Windows.Forms.Label();
            this.changeFNameTab = new System.Windows.Forms.TabPage();
            this.changeFNamePanel = new System.Windows.Forms.Panel();
            this.changeFNameButton = new System.Windows.Forms.Button();
            this.cancelFNameChange = new System.Windows.Forms.Button();
            this.confrimFNameLabel = new System.Windows.Forms.Label();
            this.newFNameLabel = new System.Windows.Forms.Label();
            this.confirmFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameLabel = new System.Windows.Forms.Label();
            this.changeDescTab = new System.Windows.Forms.TabPage();
            this.changeDescPanel = new System.Windows.Forms.Panel();
            this.changeDescTextBox = new System.Windows.Forms.TextBox();
            this.changeDescButton = new System.Windows.Forms.Button();
            this.cancelDescButton = new System.Windows.Forms.Button();
            this.changeDescLabel = new System.Windows.Forms.Label();
            this.changeDetailsTabControl = new System.Windows.Forms.TabControl();
            this.helpButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeDOBTab.SuspendLayout();
            this.changeDOBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DOB_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOB_Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOB_Day)).BeginInit();
            this.changePasswordTab.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
            this.changeLNameTab.SuspendLayout();
            this.changeLNamePanel.SuspendLayout();
            this.changeFNameTab.SuspendLayout();
            this.changeFNamePanel.SuspendLayout();
            this.changeDescTab.SuspendLayout();
            this.changeDescPanel.SuspendLayout();
            this.changeDetailsTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailLabel.Location = new System.Drawing.Point(65, 113);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(351, 29);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "<e-mail>";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fnameLabel.Location = new System.Drawing.Point(65, 166);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(160, 29);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "<first_name>";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fnameLabel.Click += new System.EventHandler(this.fnameLabel_Click);
            // 
            // lnameLabel
            // 
            this.lnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnameLabel.Location = new System.Drawing.Point(65, 235);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(160, 29);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "<last_name>";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnameLabel.Click += new System.EventHandler(this.lnameLabel_Click);
            // 
            // dobLabel
            // 
            this.dobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dobLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dobLabel.Location = new System.Drawing.Point(65, 295);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(160, 29);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "<date_of_birth>";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dobLabel.Click += new System.EventHandler(this.dobLabel_Click);
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePasswordLabel.Location = new System.Drawing.Point(65, 358);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(160, 29);
            this.changePasswordLabel.TabIndex = 6;
            this.changePasswordLabel.Text = "Change Password";
            this.changePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePasswordLabel.Click += new System.EventHandler(this.changePasswordLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.descriptionLabel.Location = new System.Drawing.Point(296, 156);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(422, 231);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "<description>";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descTitleLabel
            // 
            this.descTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.descTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.descTitleLabel.Location = new System.Drawing.Point(511, 113);
            this.descTitleLabel.Name = "descTitleLabel";
            this.descTitleLabel.Size = new System.Drawing.Size(207, 43);
            this.descTitleLabel.TabIndex = 8;
            this.descTitleLabel.Text = "Details";
            this.descTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descTitleLabel.Click += new System.EventHandler(this.descTitleLabel_Click);
            // 
            // updateInfoLabel
            // 
            this.updateInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateInfoLabel.Location = new System.Drawing.Point(292, 84);
            this.updateInfoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.updateInfoLabel.Name = "updateInfoLabel";
            this.updateInfoLabel.Size = new System.Drawing.Size(213, 18);
            this.updateInfoLabel.TabIndex = 11;
            this.updateInfoLabel.Text = "Please update your information";
            this.updateInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDOBTab
            // 
            this.changeDOBTab.Controls.Add(this.changeDOBPanel);
            this.changeDOBTab.Location = new System.Drawing.Point(4, 28);
            this.changeDOBTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDOBTab.Name = "changeDOBTab";
            this.changeDOBTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDOBTab.Size = new System.Drawing.Size(656, 271);
            this.changeDOBTab.TabIndex = 4;
            this.changeDOBTab.Text = "Change Date Of Birth";
            this.changeDOBTab.UseVisualStyleBackColor = true;
            // 
            // changeDOBPanel
            // 
            this.changeDOBPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeDOBPanel.Controls.Add(this.DOB_Year);
            this.changeDOBPanel.Controls.Add(this.DOB_Month);
            this.changeDOBPanel.Controls.Add(this.DOB_Day);
            this.changeDOBPanel.Controls.Add(this.changeDOBButton);
            this.changeDOBPanel.Controls.Add(this.cancelDOBButton);
            this.changeDOBPanel.Controls.Add(this.label2);
            this.changeDOBPanel.Controls.Add(this.changeDOBLabel);
            this.changeDOBPanel.Location = new System.Drawing.Point(0, 3);
            this.changeDOBPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeDOBPanel.Name = "changeDOBPanel";
            this.changeDOBPanel.Size = new System.Drawing.Size(660, 272);
            this.changeDOBPanel.TabIndex = 13;
            this.changeDOBPanel.Visible = false;
            // 
            // DOB_Year
            // 
            this.DOB_Year.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DOB_Year.Location = new System.Drawing.Point(389, 97);
            this.DOB_Year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOB_Year.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.DOB_Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.DOB_Year.Name = "DOB_Year";
            this.DOB_Year.Size = new System.Drawing.Size(67, 22);
            this.DOB_Year.TabIndex = 11;
            this.DOB_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DOB_Year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // DOB_Month
            // 
            this.DOB_Month.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DOB_Month.Location = new System.Drawing.Point(332, 97);
            this.DOB_Month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOB_Month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DOB_Month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DOB_Month.Name = "DOB_Month";
            this.DOB_Month.Size = new System.Drawing.Size(52, 22);
            this.DOB_Month.TabIndex = 10;
            this.DOB_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DOB_Month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DOB_Day
            // 
            this.DOB_Day.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DOB_Day.Location = new System.Drawing.Point(275, 97);
            this.DOB_Day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DOB_Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DOB_Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DOB_Day.Name = "DOB_Day";
            this.DOB_Day.Size = new System.Drawing.Size(52, 22);
            this.DOB_Day.TabIndex = 9;
            this.DOB_Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DOB_Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // changeDOBButton
            // 
            this.changeDOBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeDOBButton.Location = new System.Drawing.Point(305, 171);
            this.changeDOBButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeDOBButton.Name = "changeDOBButton";
            this.changeDOBButton.Size = new System.Drawing.Size(167, 28);
            this.changeDOBButton.TabIndex = 8;
            this.changeDOBButton.Text = "Change Date of Birth";
            this.changeDOBButton.UseVisualStyleBackColor = false;
            this.changeDOBButton.Click += new System.EventHandler(this.changeDOBButton_Click);
            // 
            // cancelDOBButton
            // 
            this.cancelDOBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelDOBButton.Location = new System.Drawing.Point(213, 171);
            this.cancelDOBButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cancelDOBButton.Name = "cancelDOBButton";
            this.cancelDOBButton.Size = new System.Drawing.Size(83, 28);
            this.cancelDOBButton.TabIndex = 7;
            this.cancelDOBButton.Text = "Cancel";
            this.cancelDOBButton.UseVisualStyleBackColor = false;
            this.cancelDOBButton.Click += new System.EventHandler(this.cancelDOBButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(148, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of Birth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDOBLabel
            // 
            this.changeDOBLabel.AutoSize = true;
            this.changeDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDOBLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeDOBLabel.Location = new System.Drawing.Point(208, 38);
            this.changeDOBLabel.Name = "changeDOBLabel";
            this.changeDOBLabel.Size = new System.Drawing.Size(239, 29);
            this.changeDOBLabel.TabIndex = 0;
            this.changeDOBLabel.Text = "Change Date Of Birth";
            this.changeDOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePasswordTab
            // 
            this.changePasswordTab.Controls.Add(this.changePasswordPanel);
            this.changePasswordTab.Location = new System.Drawing.Point(4, 28);
            this.changePasswordTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePasswordTab.Name = "changePasswordTab";
            this.changePasswordTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePasswordTab.Size = new System.Drawing.Size(656, 271);
            this.changePasswordTab.TabIndex = 3;
            this.changePasswordTab.Text = "Change Password";
            this.changePasswordTab.UseVisualStyleBackColor = true;
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePasswordPanel.Controls.Add(this.changePassButton);
            this.changePasswordPanel.Controls.Add(this.cancelPassChangeButton);
            this.changePasswordPanel.Controls.Add(this.confrimNewPassLabel);
            this.changePasswordPanel.Controls.Add(this.newPasswordLabel);
            this.changePasswordPanel.Controls.Add(this.oldPasswordLabel);
            this.changePasswordPanel.Controls.Add(this.confirmNewPassTextBox);
            this.changePasswordPanel.Controls.Add(this.newPassTextBox);
            this.changePasswordPanel.Controls.Add(this.oldPassTextBox);
            this.changePasswordPanel.Controls.Add(this.changePasswordTitle);
            this.changePasswordPanel.Location = new System.Drawing.Point(5, 5);
            this.changePasswordPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(632, 270);
            this.changePasswordPanel.TabIndex = 10;
            this.changePasswordPanel.Visible = false;
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changePassButton.Location = new System.Drawing.Point(316, 196);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(140, 28);
            this.changePassButton.TabIndex = 8;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelPassChangeButton.Location = new System.Drawing.Point(228, 196);
            this.cancelPassChangeButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cancelPassChangeButton.Name = "cancelPassChangeButton";
            this.cancelPassChangeButton.Size = new System.Drawing.Size(83, 28);
            this.cancelPassChangeButton.TabIndex = 7;
            this.cancelPassChangeButton.Text = "Cancel";
            this.cancelPassChangeButton.UseVisualStyleBackColor = false;
            this.cancelPassChangeButton.Click += new System.EventHandler(this.cancelPassChangeButton_Click);
            // 
            // confrimNewPassLabel
            // 
            this.confrimNewPassLabel.AutoSize = true;
            this.confrimNewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimNewPassLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.confrimNewPassLabel.Location = new System.Drawing.Point(80, 149);
            this.confrimNewPassLabel.Name = "confrimNewPassLabel";
            this.confrimNewPassLabel.Size = new System.Drawing.Size(185, 20);
            this.confrimNewPassLabel.TabIndex = 6;
            this.confrimNewPassLabel.Text = "Confrim New Password";
            this.confrimNewPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newPasswordLabel.Location = new System.Drawing.Point(149, 113);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(121, 20);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "New Password";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.oldPasswordLabel.Location = new System.Drawing.Point(156, 75);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(114, 20);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNewPassTextBox
            // 
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(304, 149);
            this.confirmNewPassTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.Size = new System.Drawing.Size(213, 22);
            this.confirmNewPassTextBox.TabIndex = 3;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(304, 113);
            this.newPassTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(213, 22);
            this.newPassTextBox.TabIndex = 2;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(304, 75);
            this.oldPassTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(213, 22);
            this.oldPassTextBox.TabIndex = 1;
            // 
            // changePasswordTitle
            // 
            this.changePasswordTitle.AutoSize = true;
            this.changePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePasswordTitle.Location = new System.Drawing.Point(217, 27);
            this.changePasswordTitle.Name = "changePasswordTitle";
            this.changePasswordTitle.Size = new System.Drawing.Size(210, 29);
            this.changePasswordTitle.TabIndex = 0;
            this.changePasswordTitle.Text = "Change Password";
            this.changePasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLNameTab
            // 
            this.changeLNameTab.Controls.Add(this.changeLNamePanel);
            this.changeLNameTab.Location = new System.Drawing.Point(4, 28);
            this.changeLNameTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNameTab.Name = "changeLNameTab";
            this.changeLNameTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNameTab.Size = new System.Drawing.Size(656, 271);
            this.changeLNameTab.TabIndex = 2;
            this.changeLNameTab.Text = "Change Last Name";
            this.changeLNameTab.UseVisualStyleBackColor = true;
            // 
            // changeLNamePanel
            // 
            this.changeLNamePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLNamePanel.Controls.Add(this.changeLNameButton);
            this.changeLNamePanel.Controls.Add(this.cancelLNameButton);
            this.changeLNamePanel.Controls.Add(this.confrimLNameLabel);
            this.changeLNamePanel.Controls.Add(this.newLNameLabel);
            this.changeLNamePanel.Controls.Add(this.confirmLNameTextBox);
            this.changeLNamePanel.Controls.Add(this.changeLNameTextBox);
            this.changeLNamePanel.Controls.Add(this.changeLNameLabel);
            this.changeLNamePanel.Location = new System.Drawing.Point(5, 4);
            this.changeLNamePanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeLNamePanel.Name = "changeLNamePanel";
            this.changeLNamePanel.Size = new System.Drawing.Size(632, 271);
            this.changeLNamePanel.TabIndex = 12;
            this.changeLNamePanel.Visible = false;
            // 
            // changeLNameButton
            // 
            this.changeLNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeLNameButton.Location = new System.Drawing.Point(303, 197);
            this.changeLNameButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeLNameButton.Name = "changeLNameButton";
            this.changeLNameButton.Size = new System.Drawing.Size(153, 28);
            this.changeLNameButton.TabIndex = 8;
            this.changeLNameButton.Text = "Change Last Name";
            this.changeLNameButton.UseVisualStyleBackColor = false;
            this.changeLNameButton.Click += new System.EventHandler(this.changeLNameButton_Click);
            // 
            // cancelLNameButton
            // 
            this.cancelLNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelLNameButton.Location = new System.Drawing.Point(215, 197);
            this.cancelLNameButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cancelLNameButton.Name = "cancelLNameButton";
            this.cancelLNameButton.Size = new System.Drawing.Size(83, 28);
            this.cancelLNameButton.TabIndex = 7;
            this.cancelLNameButton.Text = "Cancel";
            this.cancelLNameButton.UseVisualStyleBackColor = false;
            this.cancelLNameButton.Click += new System.EventHandler(this.cancelLNameButton_Click);
            // 
            // confrimLNameLabel
            // 
            this.confrimLNameLabel.AutoSize = true;
            this.confrimLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimLNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.confrimLNameLabel.Location = new System.Drawing.Point(131, 137);
            this.confrimLNameLabel.Name = "confrimLNameLabel";
            this.confrimLNameLabel.Size = new System.Drawing.Size(117, 20);
            this.confrimLNameLabel.TabIndex = 5;
            this.confrimLNameLabel.Text = "Confirm Name";
            this.confrimLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newLNameLabel
            // 
            this.newLNameLabel.AutoSize = true;
            this.newLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newLNameLabel.Location = new System.Drawing.Point(159, 97);
            this.newLNameLabel.Name = "newLNameLabel";
            this.newLNameLabel.Size = new System.Drawing.Size(91, 20);
            this.newLNameLabel.TabIndex = 4;
            this.newLNameLabel.Text = "Last Name";
            this.newLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmLNameTextBox
            // 
            this.confirmLNameTextBox.Location = new System.Drawing.Point(281, 135);
            this.confirmLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.confirmLNameTextBox.Name = "confirmLNameTextBox";
            this.confirmLNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.confirmLNameTextBox.TabIndex = 2;
            // 
            // changeLNameTextBox
            // 
            this.changeLNameTextBox.Location = new System.Drawing.Point(281, 97);
            this.changeLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeLNameTextBox.Name = "changeLNameTextBox";
            this.changeLNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.changeLNameTextBox.TabIndex = 1;
            // 
            // changeLNameLabel
            // 
            this.changeLNameLabel.AutoSize = true;
            this.changeLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeLNameLabel.Location = new System.Drawing.Point(215, 38);
            this.changeLNameLabel.Name = "changeLNameLabel";
            this.changeLNameLabel.Size = new System.Drawing.Size(218, 29);
            this.changeLNameLabel.TabIndex = 0;
            this.changeLNameLabel.Text = "Change Last Name";
            this.changeLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeFNameTab
            // 
            this.changeFNameTab.Controls.Add(this.changeFNamePanel);
            this.changeFNameTab.Location = new System.Drawing.Point(4, 28);
            this.changeFNameTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNameTab.Name = "changeFNameTab";
            this.changeFNameTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNameTab.Size = new System.Drawing.Size(656, 271);
            this.changeFNameTab.TabIndex = 1;
            this.changeFNameTab.Text = "Change First Name";
            this.changeFNameTab.UseVisualStyleBackColor = true;
            // 
            // changeFNamePanel
            // 
            this.changeFNamePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeFNamePanel.Controls.Add(this.changeFNameButton);
            this.changeFNamePanel.Controls.Add(this.cancelFNameChange);
            this.changeFNamePanel.Controls.Add(this.confrimFNameLabel);
            this.changeFNamePanel.Controls.Add(this.newFNameLabel);
            this.changeFNamePanel.Controls.Add(this.confirmFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameLabel);
            this.changeFNamePanel.Location = new System.Drawing.Point(5, 4);
            this.changeFNamePanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeFNamePanel.Name = "changeFNamePanel";
            this.changeFNamePanel.Size = new System.Drawing.Size(632, 271);
            this.changeFNamePanel.TabIndex = 11;
            this.changeFNamePanel.Visible = false;
            // 
            // changeFNameButton
            // 
            this.changeFNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeFNameButton.Location = new System.Drawing.Point(305, 197);
            this.changeFNameButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeFNameButton.Name = "changeFNameButton";
            this.changeFNameButton.Size = new System.Drawing.Size(140, 28);
            this.changeFNameButton.TabIndex = 8;
            this.changeFNameButton.Text = "Change First Name";
            this.changeFNameButton.UseVisualStyleBackColor = false;
            this.changeFNameButton.Click += new System.EventHandler(this.changeFNameButton_Click);
            // 
            // cancelFNameChange
            // 
            this.cancelFNameChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelFNameChange.Location = new System.Drawing.Point(220, 197);
            this.cancelFNameChange.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cancelFNameChange.Name = "cancelFNameChange";
            this.cancelFNameChange.Size = new System.Drawing.Size(83, 28);
            this.cancelFNameChange.TabIndex = 7;
            this.cancelFNameChange.Text = "Cancel";
            this.cancelFNameChange.UseVisualStyleBackColor = false;
            this.cancelFNameChange.Click += new System.EventHandler(this.cancelFNameChange_Click);
            // 
            // confrimFNameLabel
            // 
            this.confrimFNameLabel.AutoSize = true;
            this.confrimFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimFNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.confrimFNameLabel.Location = new System.Drawing.Point(115, 137);
            this.confrimFNameLabel.Name = "confrimFNameLabel";
            this.confrimFNameLabel.Size = new System.Drawing.Size(117, 20);
            this.confrimFNameLabel.TabIndex = 5;
            this.confrimFNameLabel.Text = "Confirm Name";
            this.confrimFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newFNameLabel
            // 
            this.newFNameLabel.AutoSize = true;
            this.newFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newFNameLabel.Location = new System.Drawing.Point(143, 97);
            this.newFNameLabel.Name = "newFNameLabel";
            this.newFNameLabel.Size = new System.Drawing.Size(92, 20);
            this.newFNameLabel.TabIndex = 4;
            this.newFNameLabel.Text = "First Name";
            this.newFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmFNameTextBox
            // 
            this.confirmFNameTextBox.Location = new System.Drawing.Point(272, 135);
            this.confirmFNameTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.confirmFNameTextBox.Name = "confirmFNameTextBox";
            this.confirmFNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.confirmFNameTextBox.TabIndex = 2;
            // 
            // changeFNameTextBox
            // 
            this.changeFNameTextBox.Location = new System.Drawing.Point(272, 97);
            this.changeFNameTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeFNameTextBox.Name = "changeFNameTextBox";
            this.changeFNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.changeFNameTextBox.TabIndex = 1;
            // 
            // changeFNameLabel
            // 
            this.changeFNameLabel.AutoSize = true;
            this.changeFNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeFNameLabel.Location = new System.Drawing.Point(215, 38);
            this.changeFNameLabel.Name = "changeFNameLabel";
            this.changeFNameLabel.Size = new System.Drawing.Size(221, 29);
            this.changeFNameLabel.TabIndex = 0;
            this.changeFNameLabel.Text = "Change First Name";
            this.changeFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDescTab
            // 
            this.changeDescTab.Controls.Add(this.changeDescPanel);
            this.changeDescTab.Location = new System.Drawing.Point(4, 28);
            this.changeDescTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescTab.Name = "changeDescTab";
            this.changeDescTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescTab.Size = new System.Drawing.Size(656, 271);
            this.changeDescTab.TabIndex = 0;
            this.changeDescTab.Text = "Change Description";
            this.changeDescTab.UseVisualStyleBackColor = true;
            // 
            // changeDescPanel
            // 
            this.changeDescPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeDescPanel.Controls.Add(this.changeDescTextBox);
            this.changeDescPanel.Controls.Add(this.changeDescButton);
            this.changeDescPanel.Controls.Add(this.cancelDescButton);
            this.changeDescPanel.Controls.Add(this.changeDescLabel);
            this.changeDescPanel.Location = new System.Drawing.Point(5, 4);
            this.changeDescPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeDescPanel.Name = "changeDescPanel";
            this.changeDescPanel.Size = new System.Drawing.Size(632, 271);
            this.changeDescPanel.TabIndex = 13;
            this.changeDescPanel.Visible = false;
            // 
            // changeDescTextBox
            // 
            this.changeDescTextBox.Location = new System.Drawing.Point(54, 50);
            this.changeDescTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescTextBox.Multiline = true;
            this.changeDescTextBox.Name = "changeDescTextBox";
            this.changeDescTextBox.Size = new System.Drawing.Size(529, 147);
            this.changeDescTextBox.TabIndex = 9;
            // 
            // changeDescButton
            // 
            this.changeDescButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeDescButton.Location = new System.Drawing.Point(316, 210);
            this.changeDescButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.changeDescButton.Name = "changeDescButton";
            this.changeDescButton.Size = new System.Drawing.Size(140, 28);
            this.changeDescButton.TabIndex = 8;
            this.changeDescButton.Text = "Change Description";
            this.changeDescButton.UseVisualStyleBackColor = false;
            this.changeDescButton.Click += new System.EventHandler(this.changeDescButton_Click);
            // 
            // cancelDescButton
            // 
            this.cancelDescButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelDescButton.Location = new System.Drawing.Point(220, 210);
            this.cancelDescButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cancelDescButton.Name = "cancelDescButton";
            this.cancelDescButton.Size = new System.Drawing.Size(83, 28);
            this.cancelDescButton.TabIndex = 7;
            this.cancelDescButton.Text = "Cancel";
            this.cancelDescButton.UseVisualStyleBackColor = false;
            this.cancelDescButton.Click += new System.EventHandler(this.cancelDescButton_Click);
            // 
            // changeDescLabel
            // 
            this.changeDescLabel.AutoSize = true;
            this.changeDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDescLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeDescLabel.Location = new System.Drawing.Point(197, 9);
            this.changeDescLabel.Name = "changeDescLabel";
            this.changeDescLabel.Size = new System.Drawing.Size(225, 29);
            this.changeDescLabel.TabIndex = 0;
            this.changeDescLabel.Text = "Change Description";
            this.changeDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDetailsTabControl
            // 
            this.changeDetailsTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.changeDetailsTabControl.Controls.Add(this.changeDescTab);
            this.changeDetailsTabControl.Controls.Add(this.changeFNameTab);
            this.changeDetailsTabControl.Controls.Add(this.changeLNameTab);
            this.changeDetailsTabControl.Controls.Add(this.changePasswordTab);
            this.changeDetailsTabControl.Controls.Add(this.changeDOBTab);
            this.changeDetailsTabControl.Location = new System.Drawing.Point(54, 84);
            this.changeDetailsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDetailsTabControl.Name = "changeDetailsTabControl";
            this.changeDetailsTabControl.SelectedIndex = 0;
            this.changeDetailsTabControl.Size = new System.Drawing.Size(664, 303);
            this.changeDetailsTabControl.TabIndex = 12;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(645, 23);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(98, 44);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(28, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 44);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 47);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(-1, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 100);
            this.panel1.TabIndex = 16;
            // 
            // UserTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(770, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.changeDetailsTabControl);
            this.Controls.Add(this.updateInfoLabel);
            this.Controls.Add(this.descTitleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "UserTabForm";
            this.Text = "User";
            this.changeDOBTab.ResumeLayout(false);
            this.changeDOBPanel.ResumeLayout(false);
            this.changeDOBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DOB_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOB_Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOB_Day)).EndInit();
            this.changePasswordTab.ResumeLayout(false);
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.changeLNameTab.ResumeLayout(false);
            this.changeLNamePanel.ResumeLayout(false);
            this.changeLNamePanel.PerformLayout();
            this.changeFNameTab.ResumeLayout(false);
            this.changeFNamePanel.ResumeLayout(false);
            this.changeFNamePanel.PerformLayout();
            this.changeDescTab.ResumeLayout(false);
            this.changeDescPanel.ResumeLayout(false);
            this.changeDescPanel.PerformLayout();
            this.changeDetailsTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descTitleLabel;
        private System.Windows.Forms.Label updateInfoLabel;
        private System.Windows.Forms.TabPage changeDOBTab;
        private System.Windows.Forms.Panel changeDOBPanel;
        private System.Windows.Forms.NumericUpDown DOB_Year;
        private System.Windows.Forms.NumericUpDown DOB_Month;
        private System.Windows.Forms.NumericUpDown DOB_Day;
        private System.Windows.Forms.Button changeDOBButton;
        private System.Windows.Forms.Button cancelDOBButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label changeDOBLabel;
        private System.Windows.Forms.TabPage changePasswordTab;
        private System.Windows.Forms.Panel changePasswordPanel;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button cancelPassChangeButton;
        private System.Windows.Forms.Label confrimNewPassLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox confirmNewPassTextBox;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.Label changePasswordTitle;
        private System.Windows.Forms.TabPage changeLNameTab;
        private System.Windows.Forms.Panel changeLNamePanel;
        private System.Windows.Forms.Button changeLNameButton;
        private System.Windows.Forms.Button cancelLNameButton;
        private System.Windows.Forms.Label confrimLNameLabel;
        private System.Windows.Forms.Label newLNameLabel;
        private System.Windows.Forms.TextBox confirmLNameTextBox;
        private System.Windows.Forms.TextBox changeLNameTextBox;
        private System.Windows.Forms.Label changeLNameLabel;
        private System.Windows.Forms.TabPage changeFNameTab;
        private System.Windows.Forms.Panel changeFNamePanel;
        private System.Windows.Forms.Button changeFNameButton;
        private System.Windows.Forms.Button cancelFNameChange;
        private System.Windows.Forms.Label confrimFNameLabel;
        private System.Windows.Forms.Label newFNameLabel;
        private System.Windows.Forms.TextBox confirmFNameTextBox;
        private System.Windows.Forms.TextBox changeFNameTextBox;
        private System.Windows.Forms.Label changeFNameLabel;
        private System.Windows.Forms.TabPage changeDescTab;
        private System.Windows.Forms.Panel changeDescPanel;
        private System.Windows.Forms.TextBox changeDescTextBox;
        private System.Windows.Forms.Button changeDescButton;
        private System.Windows.Forms.Button cancelDescButton;
        private System.Windows.Forms.Label changeDescLabel;
        private System.Windows.Forms.TabControl changeDetailsTabControl;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}