namespace WindowsFormsApp1
{
    partial class Bai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lable11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dsMhDiem = new System.Windows.Forms.RichTextBox();
            this.dsDiem = new System.Windows.Forms.TextBox();
            this.Xuất = new System.Windows.Forms.Button();
            this.cao_nhat = new System.Windows.Forms.TextBox();
            this.dtb = new System.Windows.Forms.TextBox();
            this.mon_dau = new System.Windows.Forms.TextBox();
            this.hoc_luc = new System.Windows.Forms.TextBox();
            this.thap_nhat = new System.Windows.Forms.TextBox();
            this.mon_rot = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(249, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách môn học và điểm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.Location = new System.Drawing.Point(48, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm trung bình";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label100.Location = new System.Drawing.Point(48, 362);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(147, 19);
            this.label100.TabIndex = 3;
            this.label100.Text = "Môn có điểm cao nhất";
            this.label100.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.Location = new System.Drawing.Point(48, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số môn đậu";
            // 
            // lable11
            // 
            this.lable11.AutoSize = true;
            this.lable11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lable11.Location = new System.Drawing.Point(482, 316);
            this.lable11.Name = "lable11";
            this.lable11.Size = new System.Drawing.Size(104, 19);
            this.lable11.TabIndex = 5;
            this.lable11.Text = "Xếp loại học lực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.Location = new System.Drawing.Point(482, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số môn không đậu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label12.Location = new System.Drawing.Point(482, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Môn có điểm thấp nhất";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(48, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Danh sách điểm";
            // 
            // dsMhDiem
            // 
            this.dsMhDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dsMhDiem.Location = new System.Drawing.Point(52, 170);
            this.dsMhDiem.Name = "dsMhDiem";
            this.dsMhDiem.ReadOnly = true;
            this.dsMhDiem.Size = new System.Drawing.Size(676, 111);
            this.dsMhDiem.TabIndex = 9;
            this.dsMhDiem.Text = "";
            // 
            // dsDiem
            // 
            this.dsDiem.BackColor = System.Drawing.SystemColors.Window;
            this.dsDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dsDiem.Location = new System.Drawing.Point(255, 81);
            this.dsDiem.Name = "dsDiem";
            this.dsDiem.Size = new System.Drawing.Size(479, 22);
            this.dsDiem.TabIndex = 10;
            // 
            // Xuất
            // 
            this.Xuất.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Xuất.Location = new System.Drawing.Point(449, 125);
            this.Xuất.Name = "Xuất";
            this.Xuất.Size = new System.Drawing.Size(93, 37);
            this.Xuất.TabIndex = 11;
            this.Xuất.Text = "Xuất";
            this.Xuất.UseVisualStyleBackColor = true;
            this.Xuất.Click += new System.EventHandler(this.Xuất_Click);
            // 
            // cao_nhat
            // 
            this.cao_nhat.Location = new System.Drawing.Point(218, 360);
            this.cao_nhat.Name = "cao_nhat";
            this.cao_nhat.ReadOnly = true;
            this.cao_nhat.Size = new System.Drawing.Size(100, 22);
            this.cao_nhat.TabIndex = 13;
            this.cao_nhat.TextChanged += new System.EventHandler(this.cao_nhat_TextChanged);
            // 
            // dtb
            // 
            this.dtb.Location = new System.Drawing.Point(218, 314);
            this.dtb.Name = "dtb";
            this.dtb.ReadOnly = true;
            this.dtb.Size = new System.Drawing.Size(100, 22);
            this.dtb.TabIndex = 14;
            this.dtb.TextChanged += new System.EventHandler(this.dtb_TextChanged);
            // 
            // mon_dau
            // 
            this.mon_dau.Location = new System.Drawing.Point(218, 402);
            this.mon_dau.Name = "mon_dau";
            this.mon_dau.ReadOnly = true;
            this.mon_dau.Size = new System.Drawing.Size(100, 22);
            this.mon_dau.TabIndex = 15;
            // 
            // hoc_luc
            // 
            this.hoc_luc.Location = new System.Drawing.Point(650, 314);
            this.hoc_luc.Name = "hoc_luc";
            this.hoc_luc.ReadOnly = true;
            this.hoc_luc.Size = new System.Drawing.Size(100, 22);
            this.hoc_luc.TabIndex = 16;
            // 
            // thap_nhat
            // 
            this.thap_nhat.Location = new System.Drawing.Point(650, 360);
            this.thap_nhat.Name = "thap_nhat";
            this.thap_nhat.ReadOnly = true;
            this.thap_nhat.Size = new System.Drawing.Size(100, 22);
            this.thap_nhat.TabIndex = 17;
            this.thap_nhat.TextChanged += new System.EventHandler(this.thap_nhat_TextChanged);
            // 
            // mon_rot
            // 
            this.mon_rot.Location = new System.Drawing.Point(650, 400);
            this.mon_rot.Name = "mon_rot";
            this.mon_rot.ReadOnly = true;
            this.mon_rot.Size = new System.Drawing.Size(100, 22);
            this.mon_rot.TabIndex = 18;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(582, 125);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(84, 37);
            this.xoa.TabIndex = 19;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.mon_rot);
            this.Controls.Add(this.thap_nhat);
            this.Controls.Add(this.hoc_luc);
            this.Controls.Add(this.mon_dau);
            this.Controls.Add(this.dtb);
            this.Controls.Add(this.cao_nhat);
            this.Controls.Add(this.Xuất);
            this.Controls.Add(this.dsDiem);
            this.Controls.Add(this.dsMhDiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lable11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox dsMhDiem;
        private System.Windows.Forms.TextBox dsDiem;
        private System.Windows.Forms.Button Xuất;
        private System.Windows.Forms.TextBox cao_nhat;
        private System.Windows.Forms.TextBox dtb;
        private System.Windows.Forms.TextBox mon_dau;
        private System.Windows.Forms.TextBox hoc_luc;
        private System.Windows.Forms.TextBox thap_nhat;
        private System.Windows.Forms.TextBox mon_rot;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button button1;
    }
}