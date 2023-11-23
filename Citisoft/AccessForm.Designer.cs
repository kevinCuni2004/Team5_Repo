using System.Reflection.Emit;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.usernameButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameIdTextBox = new System.Windows.Forms.TextBox();
            this.profileIdTextBox = new System.Windows.Forms.TextBox();
            this.statusIdTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this._Database__2_DataSet = new Citisoft._Database__2_DataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new Citisoft._Database__2_DataSetTableAdapters.ProfileTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusValidation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Database__2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.vScrollBar1.Location = new System.Drawing.Point(762, 106);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(27, 282);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.9604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 67);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // usernameIdTextBox
            // 
            this.usernameIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameIdTextBox.Location = new System.Drawing.Point(228, 3);
            this.usernameIdTextBox.Multiline = true;
            this.usernameIdTextBox.Name = "usernameIdTextBox";
            this.usernameIdTextBox.ReadOnly = true;
            this.usernameIdTextBox.Size = new System.Drawing.Size(341, 61);
            this.usernameIdTextBox.TabIndex = 11;
            this.usernameIdTextBox.Text = "<username>";
            this.usernameIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profileIdTextBox
            // 
            this.profileIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.profileIdTextBox.Location = new System.Drawing.Point(3, 3);
            this.profileIdTextBox.Multiline = true;
            this.profileIdTextBox.Name = "profileIdTextBox";
            this.profileIdTextBox.ReadOnly = true;
            this.profileIdTextBox.Size = new System.Drawing.Size(115, 61);
            this.profileIdTextBox.TabIndex = 9;
            this.profileIdTextBox.Text = "<profile_Id>";
            this.profileIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusIdTextBox
            // 
            this.statusIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statusIdTextBox.Location = new System.Drawing.Point(124, 3);
            this.statusIdTextBox.Multiline = true;
            this.statusIdTextBox.Name = "statusIdTextBox";
            this.statusIdTextBox.ReadOnly = true;
            this.statusIdTextBox.Size = new System.Drawing.Size(98, 61);
            this.statusIdTextBox.TabIndex = 10;
            this.statusIdTextBox.Text = "<status>";
            this.statusIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(303, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 45);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Citisoft";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(841, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 482);
            this.panel1.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(487, 40);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 48);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(602, 40);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(98, 48);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // _Database__2_DataSet
            // 
            this._Database__2_DataSet.DataSetName = "_Database__2_DataSet";
            this._Database__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this._Database__2_DataSet;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.profileIdTextBox);
            this.flowLayoutPanel1.Controls.Add(this.statusIdTextBox);
            this.flowLayoutPanel1.Controls.Add(this.usernameIdTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 242);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // statusValidation
            // 
            this.statusValidation.AutoSize = true;
            this.statusValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusValidation.ForeColor = System.Drawing.Color.Red;
            this.statusValidation.Location = new System.Drawing.Point(212, 106);
            this.statusValidation.Name = "statusValidation";
            this.statusValidation.Size = new System.Drawing.Size(377, 22);
            this.statusValidation.TabIndex = 11;
            this.statusValidation.Text = "Invalid number entered in status (1-Yes, 0-No)";
            this.statusValidation.Visible = false;
            // 
            // AccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 476);
            this.Controls.Add(this.statusValidation);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.usernameButton);
            this.Name = "AccessForm";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Text = "AccessForm";
            this.Load += new System.EventHandler(this.AccessForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Database__2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox profileIdTextBox;
        private System.Windows.Forms.TextBox statusIdTextBox;
        private System.Windows.Forms.TextBox usernameIdTextBox;
        private _Database__2_DataSet _Database__2_DataSet;
        private BindingSource profileBindingSource;
        private _Database__2_DataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label statusValidation;
    }
}