﻿namespace WindowsFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bài 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bài 2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Bài 3";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bài 4";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Bài 5";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(647, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
