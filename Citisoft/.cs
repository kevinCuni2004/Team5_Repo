
namespace Citisoft
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 69);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(887, 566);
            button2.Name = "button2";
            button2.Size = new Size(173, 46);
            button2.TabIndex = 1;
            button2.Text = "Send Admin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 39);
            label1.Name = "label1";
            label1.Size = new Size(246, 53);
            label1.TabIndex = 2;
            label1.Text = "Help Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 135);
            label2.Name = "label2";
            label2.Size = new Size(584, 31);
            label2.TabIndex = 3;
            label2.Text = "Please Enter your email and Describe your problem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 190);
            label3.Name = "label3";
            label3.Size = new Size(365, 31);
            label3.TabIndex = 4;
            label3.Text = "Our Administrator will help you";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 248);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(621, 364);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 673);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}
