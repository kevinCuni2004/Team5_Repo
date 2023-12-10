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
            this.newLNameLabel = new System.Windows.Forms.Label();
            this.changeLNameTextBox = new System.Windows.Forms.TextBox();
            this.changeLNameLabel = new System.Windows.Forms.Label();
            this.changeFNameTab = new System.Windows.Forms.TabPage();
            this.changeFNamePanel = new System.Windows.Forms.Panel();
            this.changeFNameButton = new System.Windows.Forms.Button();
            this.cancelFNameChange = new System.Windows.Forms.Button();
            this.newFNameLabel = new System.Windows.Forms.Label();
            this.changeFNameTextBox = new System.Windows.Forms.TextBox();
            this.changeFNameLabel = new System.Windows.Forms.Label();
            this.changeDescTab = new System.Windows.Forms.TabPage();
            this.changeDescPanel = new System.Windows.Forms.Panel();
            this.changeDescTextBox = new System.Windows.Forms.TextBox();
            this.changeDescButton = new System.Windows.Forms.Button();
            this.cancelDescButton = new System.Windows.Forms.Button();
            this.changeDescLabel = new System.Windows.Forms.Label();
            this.changeDetailsTabControl = new System.Windows.Forms.TabControl();
            this.newUserTab = new System.Windows.Forms.TabPage();
            this.newUserPanel = new System.Windows.Forms.Panel();
            this.setDetailsLabel = new System.Windows.Forms.Label();
            this.setDetailsTextBox = new System.Windows.Forms.TextBox();
            this.setDOBYear = new System.Windows.Forms.NumericUpDown();
            this.setDOBMonth = new System.Windows.Forms.NumericUpDown();
            this.setDOBDay = new System.Windows.Forms.NumericUpDown();
            this.setLNameTextBox = new System.Windows.Forms.TextBox();
            this.setFNameTextBox = new System.Windows.Forms.TextBox();
            this.setUsernameTextBox = new System.Windows.Forms.TextBox();
            this.setLNameLabel = new System.Windows.Forms.Label();
            this.setFNameLabel = new System.Windows.Forms.Label();
            this.setDOBLabel = new System.Windows.Forms.Label();
            this.setUsernameLabel = new System.Windows.Forms.Label();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.changePasswordTab.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
            this.changeLNameTab.SuspendLayout();
            this.changeLNamePanel.SuspendLayout();
            this.changeFNameTab.SuspendLayout();
            this.changeFNamePanel.SuspendLayout();
            this.changeDescTab.SuspendLayout();
            this.changeDescPanel.SuspendLayout();
            this.changeDetailsTabControl.SuspendLayout();
            this.newUserTab.SuspendLayout();
            this.newUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDOBYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDOBMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDOBDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailLabel.Location = new System.Drawing.Point(202, 155);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(395, 36);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "<e-mail>";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fnameLabel.Location = new System.Drawing.Point(202, 232);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(179, 36);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "<first_name>";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fnameLabel.Click += new System.EventHandler(this.fnameLabel_Click);
            // 
            // lnameLabel
            // 
            this.lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnameLabel.Location = new System.Drawing.Point(202, 311);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(179, 36);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "<last_name>";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnameLabel.Click += new System.EventHandler(this.lnameLabel_Click);
            // 
            // dobLabel
            // 
            this.dobLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dobLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dobLabel.Location = new System.Drawing.Point(202, 398);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(179, 36);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "<date_of_birth>";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changePasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePasswordLabel.Location = new System.Drawing.Point(202, 485);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(179, 36);
            this.changePasswordLabel.TabIndex = 6;
            this.changePasswordLabel.Text = "Change Password";
            this.changePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePasswordLabel.Click += new System.EventHandler(this.changePasswordLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.descriptionLabel.Location = new System.Drawing.Point(398, 232);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(474, 288);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "<description>";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descTitleLabel
            // 
            this.descTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.descTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.descTitleLabel.Location = new System.Drawing.Point(639, 178);
            this.descTitleLabel.Name = "descTitleLabel";
            this.descTitleLabel.Size = new System.Drawing.Size(233, 53);
            this.descTitleLabel.TabIndex = 8;
            this.descTitleLabel.Text = "Details";
            this.descTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descTitleLabel.Click += new System.EventHandler(this.descTitleLabel_Click);
            // 
            // changePasswordTab
            // 
            this.changePasswordTab.Controls.Add(this.changePasswordPanel);
            this.changePasswordTab.Location = new System.Drawing.Point(4, 32);
            this.changePasswordTab.Name = "changePasswordTab";
            this.changePasswordTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.changePasswordTab.Size = new System.Drawing.Size(739, 342);
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
            this.changePasswordPanel.Location = new System.Drawing.Point(6, 6);
            this.changePasswordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(723, 323);
            this.changePasswordPanel.TabIndex = 10;
            this.changePasswordPanel.Visible = false;
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changePassButton.Location = new System.Drawing.Point(356, 245);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(158, 35);
            this.changePassButton.TabIndex = 8;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelPassChangeButton.Location = new System.Drawing.Point(256, 245);
            this.cancelPassChangeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelPassChangeButton.Name = "cancelPassChangeButton";
            this.cancelPassChangeButton.Size = new System.Drawing.Size(93, 35);
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
            this.confrimNewPassLabel.Location = new System.Drawing.Point(90, 186);
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
            this.newPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newPasswordLabel.Location = new System.Drawing.Point(168, 142);
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
            this.oldPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.oldPasswordLabel.Location = new System.Drawing.Point(176, 94);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(134, 25);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNewPassTextBox
            // 
            this.confirmNewPassTextBox.Location = new System.Drawing.Point(342, 186);
            this.confirmNewPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmNewPassTextBox.Name = "confirmNewPassTextBox";
            this.confirmNewPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.confirmNewPassTextBox.TabIndex = 3;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(342, 142);
            this.newPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.newPassTextBox.TabIndex = 2;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(342, 94);
            this.oldPassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(240, 26);
            this.oldPassTextBox.TabIndex = 1;
            // 
            // changePasswordTitle
            // 
            this.changePasswordTitle.AutoSize = true;
            this.changePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePasswordTitle.Location = new System.Drawing.Point(244, 34);
            this.changePasswordTitle.Name = "changePasswordTitle";
            this.changePasswordTitle.Size = new System.Drawing.Size(245, 32);
            this.changePasswordTitle.TabIndex = 0;
            this.changePasswordTitle.Text = "Change Password";
            this.changePasswordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLNameTab
            // 
            this.changeLNameTab.Controls.Add(this.changeLNamePanel);
            this.changeLNameTab.Location = new System.Drawing.Point(4, 32);
            this.changeLNameTab.Name = "changeLNameTab";
            this.changeLNameTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.changeLNameTab.Size = new System.Drawing.Size(739, 342);
            this.changeLNameTab.TabIndex = 2;
            this.changeLNameTab.Text = "Change Last Name";
            this.changeLNameTab.UseVisualStyleBackColor = true;
            // 
            // changeLNamePanel
            // 
            this.changeLNamePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLNamePanel.Controls.Add(this.changeLNameButton);
            this.changeLNamePanel.Controls.Add(this.cancelLNameButton);
            this.changeLNamePanel.Controls.Add(this.newLNameLabel);
            this.changeLNamePanel.Controls.Add(this.changeLNameTextBox);
            this.changeLNamePanel.Controls.Add(this.changeLNameLabel);
            this.changeLNamePanel.Location = new System.Drawing.Point(6, 5);
            this.changeLNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNamePanel.Name = "changeLNamePanel";
            this.changeLNamePanel.Size = new System.Drawing.Size(726, 325);
            this.changeLNamePanel.TabIndex = 12;
            this.changeLNamePanel.Visible = false;
            // 
            // changeLNameButton
            // 
            this.changeLNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeLNameButton.Location = new System.Drawing.Point(340, 246);
            this.changeLNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNameButton.Name = "changeLNameButton";
            this.changeLNameButton.Size = new System.Drawing.Size(172, 35);
            this.changeLNameButton.TabIndex = 8;
            this.changeLNameButton.Text = "Change Last Name";
            this.changeLNameButton.UseVisualStyleBackColor = false;
            this.changeLNameButton.Click += new System.EventHandler(this.changeLNameButton_Click);
            // 
            // cancelLNameButton
            // 
            this.cancelLNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelLNameButton.Location = new System.Drawing.Point(242, 246);
            this.cancelLNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelLNameButton.Name = "cancelLNameButton";
            this.cancelLNameButton.Size = new System.Drawing.Size(93, 35);
            this.cancelLNameButton.TabIndex = 7;
            this.cancelLNameButton.Text = "Cancel";
            this.cancelLNameButton.UseVisualStyleBackColor = false;
            this.cancelLNameButton.Click += new System.EventHandler(this.cancelLNameButton_Click);
            // 
            // newLNameLabel
            // 
            this.newLNameLabel.AutoSize = true;
            this.newLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newLNameLabel.Location = new System.Drawing.Point(178, 140);
            this.newLNameLabel.Name = "newLNameLabel";
            this.newLNameLabel.Size = new System.Drawing.Size(106, 25);
            this.newLNameLabel.TabIndex = 4;
            this.newLNameLabel.Text = "Last Name";
            this.newLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLNameTextBox
            // 
            this.changeLNameTextBox.Location = new System.Drawing.Point(318, 140);
            this.changeLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeLNameTextBox.Name = "changeLNameTextBox";
            this.changeLNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.changeLNameTextBox.TabIndex = 1;
            // 
            // changeLNameLabel
            // 
            this.changeLNameLabel.AutoSize = true;
            this.changeLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeLNameLabel.Location = new System.Drawing.Point(244, 74);
            this.changeLNameLabel.Name = "changeLNameLabel";
            this.changeLNameLabel.Size = new System.Drawing.Size(257, 32);
            this.changeLNameLabel.TabIndex = 0;
            this.changeLNameLabel.Text = "Change Last Name";
            this.changeLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeFNameTab
            // 
            this.changeFNameTab.Controls.Add(this.changeFNamePanel);
            this.changeFNameTab.Location = new System.Drawing.Point(4, 32);
            this.changeFNameTab.Name = "changeFNameTab";
            this.changeFNameTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.changeFNameTab.Size = new System.Drawing.Size(739, 342);
            this.changeFNameTab.TabIndex = 1;
            this.changeFNameTab.Text = "Change First Name";
            this.changeFNameTab.UseVisualStyleBackColor = true;
            // 
            // changeFNamePanel
            // 
            this.changeFNamePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeFNamePanel.Controls.Add(this.changeFNameButton);
            this.changeFNamePanel.Controls.Add(this.cancelFNameChange);
            this.changeFNamePanel.Controls.Add(this.newFNameLabel);
            this.changeFNamePanel.Controls.Add(this.changeFNameTextBox);
            this.changeFNamePanel.Controls.Add(this.changeFNameLabel);
            this.changeFNamePanel.Location = new System.Drawing.Point(6, 5);
            this.changeFNamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNamePanel.Name = "changeFNamePanel";
            this.changeFNamePanel.Size = new System.Drawing.Size(723, 325);
            this.changeFNamePanel.TabIndex = 11;
            this.changeFNamePanel.Visible = false;
            // 
            // changeFNameButton
            // 
            this.changeFNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeFNameButton.Location = new System.Drawing.Point(344, 246);
            this.changeFNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNameButton.Name = "changeFNameButton";
            this.changeFNameButton.Size = new System.Drawing.Size(158, 35);
            this.changeFNameButton.TabIndex = 8;
            this.changeFNameButton.Text = "Change First Name";
            this.changeFNameButton.UseVisualStyleBackColor = false;
            this.changeFNameButton.Click += new System.EventHandler(this.changeFNameButton_Click);
            // 
            // cancelFNameChange
            // 
            this.cancelFNameChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelFNameChange.Location = new System.Drawing.Point(248, 246);
            this.cancelFNameChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelFNameChange.Name = "cancelFNameChange";
            this.cancelFNameChange.Size = new System.Drawing.Size(93, 35);
            this.cancelFNameChange.TabIndex = 7;
            this.cancelFNameChange.Text = "Cancel";
            this.cancelFNameChange.UseVisualStyleBackColor = false;
            this.cancelFNameChange.Click += new System.EventHandler(this.cancelFNameChange_Click);
            // 
            // newFNameLabel
            // 
            this.newFNameLabel.AutoSize = true;
            this.newFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newFNameLabel.Location = new System.Drawing.Point(174, 162);
            this.newFNameLabel.Name = "newFNameLabel";
            this.newFNameLabel.Size = new System.Drawing.Size(106, 25);
            this.newFNameLabel.TabIndex = 4;
            this.newFNameLabel.Text = "First Name";
            this.newFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeFNameTextBox
            // 
            this.changeFNameTextBox.Location = new System.Drawing.Point(308, 160);
            this.changeFNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeFNameTextBox.Name = "changeFNameTextBox";
            this.changeFNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.changeFNameTextBox.TabIndex = 1;
            // 
            // changeFNameLabel
            // 
            this.changeFNameLabel.AutoSize = true;
            this.changeFNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeFNameLabel.Location = new System.Drawing.Point(242, 69);
            this.changeFNameLabel.Name = "changeFNameLabel";
            this.changeFNameLabel.Size = new System.Drawing.Size(258, 32);
            this.changeFNameLabel.TabIndex = 0;
            this.changeFNameLabel.Text = "Change First Name";
            this.changeFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDescTab
            // 
            this.changeDescTab.Controls.Add(this.changeDescPanel);
            this.changeDescTab.Location = new System.Drawing.Point(4, 32);
            this.changeDescTab.Name = "changeDescTab";
            this.changeDescTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.changeDescTab.Size = new System.Drawing.Size(739, 342);
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
            this.changeDescPanel.Location = new System.Drawing.Point(6, 5);
            this.changeDescPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescPanel.Name = "changeDescPanel";
            this.changeDescPanel.Size = new System.Drawing.Size(726, 328);
            this.changeDescPanel.TabIndex = 13;
            this.changeDescPanel.Visible = false;
            // 
            // changeDescTextBox
            // 
            this.changeDescTextBox.Location = new System.Drawing.Point(60, 63);
            this.changeDescTextBox.Multiline = true;
            this.changeDescTextBox.Name = "changeDescTextBox";
            this.changeDescTextBox.Size = new System.Drawing.Size(595, 182);
            this.changeDescTextBox.TabIndex = 9;
            // 
            // changeDescButton
            // 
            this.changeDescButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.changeDescButton.Location = new System.Drawing.Point(356, 263);
            this.changeDescButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDescButton.Name = "changeDescButton";
            this.changeDescButton.Size = new System.Drawing.Size(195, 35);
            this.changeDescButton.TabIndex = 8;
            this.changeDescButton.Text = "Change Description";
            this.changeDescButton.UseVisualStyleBackColor = false;
            this.changeDescButton.Click += new System.EventHandler(this.changeDescButton_Click);
            // 
            // cancelDescButton
            // 
            this.cancelDescButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.cancelDescButton.Location = new System.Drawing.Point(248, 263);
            this.cancelDescButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelDescButton.Name = "cancelDescButton";
            this.cancelDescButton.Size = new System.Drawing.Size(93, 35);
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
            this.changeDescLabel.Location = new System.Drawing.Point(222, 11);
            this.changeDescLabel.Name = "changeDescLabel";
            this.changeDescLabel.Size = new System.Drawing.Size(264, 32);
            this.changeDescLabel.TabIndex = 0;
            this.changeDescLabel.Text = "Change Description";
            this.changeDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDetailsTabControl
            // 
            this.changeDetailsTabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeDetailsTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.changeDetailsTabControl.Controls.Add(this.changeDescTab);
            this.changeDetailsTabControl.Controls.Add(this.changeFNameTab);
            this.changeDetailsTabControl.Controls.Add(this.changeLNameTab);
            this.changeDetailsTabControl.Controls.Add(this.changePasswordTab);
            this.changeDetailsTabControl.Controls.Add(this.newUserTab);
            this.changeDetailsTabControl.Location = new System.Drawing.Point(178, 155);
            this.changeDetailsTabControl.Name = "changeDetailsTabControl";
            this.changeDetailsTabControl.SelectedIndex = 0;
            this.changeDetailsTabControl.Size = new System.Drawing.Size(747, 378);
            this.changeDetailsTabControl.TabIndex = 12;
            // 
            // newUserTab
            // 
            this.newUserTab.Controls.Add(this.newUserPanel);
            this.newUserTab.Location = new System.Drawing.Point(4, 32);
            this.newUserTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newUserTab.Name = "newUserTab";
            this.newUserTab.Size = new System.Drawing.Size(739, 342);
            this.newUserTab.TabIndex = 5;
            this.newUserTab.Text = "Enter your details";
            this.newUserTab.UseVisualStyleBackColor = true;
            // 
            // newUserPanel
            // 
            this.newUserPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newUserPanel.Controls.Add(this.setDetailsLabel);
            this.newUserPanel.Controls.Add(this.setDetailsTextBox);
            this.newUserPanel.Controls.Add(this.setDOBYear);
            this.newUserPanel.Controls.Add(this.setDOBMonth);
            this.newUserPanel.Controls.Add(this.setDOBDay);
            this.newUserPanel.Controls.Add(this.setLNameTextBox);
            this.newUserPanel.Controls.Add(this.setFNameTextBox);
            this.newUserPanel.Controls.Add(this.setUsernameTextBox);
            this.newUserPanel.Controls.Add(this.setLNameLabel);
            this.newUserPanel.Controls.Add(this.setFNameLabel);
            this.newUserPanel.Controls.Add(this.setDOBLabel);
            this.newUserPanel.Controls.Add(this.setUsernameLabel);
            this.newUserPanel.Controls.Add(this.updateInfoButton);
            this.newUserPanel.Controls.Add(this.newUserLabel);
            this.newUserPanel.Location = new System.Drawing.Point(4, 3);
            this.newUserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newUserPanel.Name = "newUserPanel";
            this.newUserPanel.Size = new System.Drawing.Size(726, 328);
            this.newUserPanel.TabIndex = 14;
            this.newUserPanel.Visible = false;
            // 
            // setDetailsLabel
            // 
            this.setDetailsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setDetailsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.setDetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDetailsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setDetailsLabel.Location = new System.Drawing.Point(426, 20);
            this.setDetailsLabel.Name = "setDetailsLabel";
            this.setDetailsLabel.Size = new System.Drawing.Size(281, 27);
            this.setDetailsLabel.TabIndex = 20;
            this.setDetailsLabel.Text = "Details";
            this.setDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setDetailsTextBox
            // 
            this.setDetailsTextBox.Location = new System.Drawing.Point(426, 48);
            this.setDetailsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setDetailsTextBox.Multiline = true;
            this.setDetailsTextBox.Name = "setDetailsTextBox";
            this.setDetailsTextBox.Size = new System.Drawing.Size(280, 218);
            this.setDetailsTextBox.TabIndex = 19;
            // 
            // setDOBYear
            // 
            this.setDOBYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setDOBYear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setDOBYear.Location = new System.Drawing.Point(292, 237);
            this.setDOBYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.setDOBYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.setDOBYear.Name = "setDOBYear";
            this.setDOBYear.Size = new System.Drawing.Size(75, 26);
            this.setDOBYear.TabIndex = 18;
            this.setDOBYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setDOBYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // setDOBMonth
            // 
            this.setDOBMonth.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setDOBMonth.Location = new System.Drawing.Point(228, 237);
            this.setDOBMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.setDOBMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setDOBMonth.Name = "setDOBMonth";
            this.setDOBMonth.Size = new System.Drawing.Size(58, 26);
            this.setDOBMonth.TabIndex = 17;
            this.setDOBMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setDOBMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setDOBDay
            // 
            this.setDOBDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setDOBDay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setDOBDay.Location = new System.Drawing.Point(164, 237);
            this.setDOBDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.setDOBDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setDOBDay.Name = "setDOBDay";
            this.setDOBDay.Size = new System.Drawing.Size(58, 26);
            this.setDOBDay.TabIndex = 16;
            this.setDOBDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setDOBDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setLNameTextBox
            // 
            this.setLNameTextBox.Location = new System.Drawing.Point(144, 175);
            this.setLNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setLNameTextBox.Name = "setLNameTextBox";
            this.setLNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.setLNameTextBox.TabIndex = 15;
            // 
            // setFNameTextBox
            // 
            this.setFNameTextBox.Location = new System.Drawing.Point(144, 126);
            this.setFNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setFNameTextBox.Name = "setFNameTextBox";
            this.setFNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.setFNameTextBox.TabIndex = 14;
            // 
            // setUsernameTextBox
            // 
            this.setUsernameTextBox.Location = new System.Drawing.Point(144, 75);
            this.setUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setUsernameTextBox.Name = "setUsernameTextBox";
            this.setUsernameTextBox.Size = new System.Drawing.Size(240, 26);
            this.setUsernameTextBox.TabIndex = 13;
            // 
            // setLNameLabel
            // 
            this.setLNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setLNameLabel.AutoSize = true;
            this.setLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setLNameLabel.Location = new System.Drawing.Point(24, 180);
            this.setLNameLabel.Name = "setLNameLabel";
            this.setLNameLabel.Size = new System.Drawing.Size(114, 25);
            this.setLNameLabel.TabIndex = 12;
            this.setLNameLabel.Text = "Last Name*";
            this.setLNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setFNameLabel
            // 
            this.setFNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setFNameLabel.AutoSize = true;
            this.setFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setFNameLabel.Location = new System.Drawing.Point(24, 128);
            this.setFNameLabel.Name = "setFNameLabel";
            this.setFNameLabel.Size = new System.Drawing.Size(114, 25);
            this.setFNameLabel.TabIndex = 11;
            this.setFNameLabel.Text = "First Name*";
            this.setFNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setDOBLabel
            // 
            this.setDOBLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setDOBLabel.AutoSize = true;
            this.setDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDOBLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setDOBLabel.Location = new System.Drawing.Point(24, 237);
            this.setDOBLabel.Name = "setDOBLabel";
            this.setDOBLabel.Size = new System.Drawing.Size(126, 25);
            this.setDOBLabel.TabIndex = 10;
            this.setDOBLabel.Text = "Date of Birth*";
            this.setDOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setUsernameLabel
            // 
            this.setUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setUsernameLabel.AutoSize = true;
            this.setUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.setUsernameLabel.Location = new System.Drawing.Point(24, 75);
            this.setUsernameLabel.Name = "setUsernameLabel";
            this.setUsernameLabel.Size = new System.Drawing.Size(110, 25);
            this.setUsernameLabel.TabIndex = 9;
            this.setUsernameLabel.Text = "Username*";
            this.setUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.updateInfoButton.Location = new System.Drawing.Point(550, 277);
            this.updateInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(158, 35);
            this.updateInfoButton.TabIndex = 8;
            this.updateInfoButton.Text = "Confirm";
            this.updateInfoButton.UseVisualStyleBackColor = false;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newUserLabel.Location = new System.Drawing.Point(86, 11);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(244, 32);
            this.newUserLabel.TabIndex = 0;
            this.newUserLabel.Text = "Enter Your Details";
            this.newUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(30, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 68);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(440, 15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(240, 58);
            this.Logo.TabIndex = 15;
            this.Logo.TabStop = false;
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.footerPanel.Location = new System.Drawing.Point(-2, 597);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1120, 54);
            this.footerPanel.TabIndex = 16;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.Location = new System.Drawing.Point(983, 29);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(121, 68);
            this.logOutButton.TabIndex = 17;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // UserTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1116, 648);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeDetailsTabControl);
            this.Controls.Add(this.descTitleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserTabForm";
            this.Text = "User";
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
            this.newUserTab.ResumeLayout(false);
            this.newUserPanel.ResumeLayout(false);
            this.newUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDOBYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDOBMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setDOBDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
        private System.Windows.Forms.Label newLNameLabel;
        private System.Windows.Forms.TextBox changeLNameTextBox;
        private System.Windows.Forms.Label changeLNameLabel;
        private System.Windows.Forms.TabPage changeFNameTab;
        private System.Windows.Forms.Panel changeFNamePanel;
        private System.Windows.Forms.Button changeFNameButton;
        private System.Windows.Forms.Button cancelFNameChange;
        private System.Windows.Forms.Label newFNameLabel;
        private System.Windows.Forms.TextBox changeFNameTextBox;
        private System.Windows.Forms.Label changeFNameLabel;
        private System.Windows.Forms.TabPage changeDescTab;
        private System.Windows.Forms.Panel changeDescPanel;
        private System.Windows.Forms.TextBox changeDescTextBox;
        private System.Windows.Forms.Button changeDescButton;
        private System.Windows.Forms.Button cancelDescButton;
        private System.Windows.Forms.Label changeDescLabel;
        private System.Windows.Forms.TabControl changeDetailsTabControl;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TabPage newUserTab;
        private System.Windows.Forms.Panel newUserPanel;
        private System.Windows.Forms.Label setLNameLabel;
        private System.Windows.Forms.Label setFNameLabel;
        private System.Windows.Forms.Label setDOBLabel;
        private System.Windows.Forms.Label setUsernameLabel;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.NumericUpDown setDOBYear;
        private System.Windows.Forms.NumericUpDown setDOBMonth;
        private System.Windows.Forms.NumericUpDown setDOBDay;
        private System.Windows.Forms.TextBox setLNameTextBox;
        private System.Windows.Forms.TextBox setFNameTextBox;
        private System.Windows.Forms.TextBox setUsernameTextBox;
        private System.Windows.Forms.Label setDetailsLabel;
        private System.Windows.Forms.TextBox setDetailsTextBox;
    }
}