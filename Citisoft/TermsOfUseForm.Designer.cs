namespace Citisoft
{
    partial class TermsOfUseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsOfUseForm));
            //this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.PDFButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            /*this.axAcroPDF1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(270, 90);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(357, 275);
            this.axAcroPDF1.TabIndex = 0;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);*/
            // 
            // PDFButton
            // 
            this.PDFButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PDFButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.PDFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.PDFButton.FlatAppearance.BorderSize = 2;
            this.PDFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PDFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PDFButton.Location = new System.Drawing.Point(533, 468);
            this.PDFButton.Name = "PDFButton";
            this.PDFButton.Size = new System.Drawing.Size(129, 55);
            this.PDFButton.TabIndex = 1;
            this.PDFButton.Text = "Open";
            this.PDFButton.UseVisualStyleBackColor = false;
            this.PDFButton.Click += new System.EventHandler(this.PDFButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(12, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 56);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TermsOfUseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1217, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.PDFButton);
            //this.Controls.Add(this.axAcroPDF1);
            this.Name = "TermsOfUseForm";
            this.Text = "TermsOfUsecs";
            this.Load += new System.EventHandler(this.TermsOfUseForm_Load);
            //((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button PDFButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}