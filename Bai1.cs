using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai1: Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iNum1, iNum2;
            long lSum;
            if (!Int32.TryParse(tbNum1.Text, out iNum1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho Số thứ 1!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNum1.Focus(); // Đưa con trỏ về ô nhập sai
                return;
            }

            if (!Int32.TryParse(tbNum2.Text, out iNum2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho Số thứ 2!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNum2.Focus();
                return;
            }

            iNum1 = Int32.Parse(tbNum1.Text);
            iNum2 = Int32.Parse(tbNum2.Text);
            lSum = iNum1 + iNum2;
            tbNum.Text = lSum.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNum.Text = tbNum1.Text = tbNum2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
