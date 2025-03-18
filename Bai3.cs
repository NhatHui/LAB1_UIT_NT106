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
    public partial class Bai3: Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iNum;
            string ans = "Khong hop le";
            if (!Int32.TryParse(Num.Text, out iNum))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Num.Focus(); 
                return;
            }
            iNum = Int32.Parse(Num.Text);
            if (iNum <0 || iNum>9)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Num.Focus();
                return;
            }
            switch (iNum)
            {
                case 0:
                    ans = "Không";
                    break;

                case 1:
                    ans = "Một";
                    break;
                case 2:
                    ans = "Hai";
                    break;
                case 3:
                    ans = "Ba";
                    break;
                case 4:
                    ans = "Bốn";
                    break;
                case 5:
                    ans = "Năm";
                    break;
                case 6:
                    ans = "Sáu";
                    break;
                case 7:
                    ans = "Bảy";
                    break;
                case 8:
                    ans = "Tám";
                    break;
                case 9:
                    ans = "Chín";
                    break;
                //case 10:
                //    ans = "Mười";
                //    break;
                default:
                    break;
            }
            ketqua.Text = ans;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Num.Clear();
            ketqua.Clear();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
