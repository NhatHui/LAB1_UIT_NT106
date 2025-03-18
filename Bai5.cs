using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai5: Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Xuất_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.AddRange(dsDiem.Text.Split(','));

            for (int i = 0; i < list.Count; i++)
            {
                if (!double.TryParse(list[i], out double a))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng điểm (1, 2.3, ...)");
                    return;
                }
                if (a < 0 || a > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ, vui lòng nhập lại!");
                    return;
                }

            }

            double maxdiem = 0;
            double mindiem = 10;
            int rot = 0;
            int dau = 0;

            dsMhDiem.Text = null;
            double tbmon = 0;
            dtb.Text = null;

            StringBuilder sb = new StringBuilder();
                
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append($"Môn {i + 1}: {list[i],-10}"); 

                tbmon += double.Parse(list[i]);
                maxdiem = Math.Max(maxdiem, double.Parse(list[i]));
                mindiem = Math.Min(mindiem, double.Parse(list[i]));

                if (double.Parse(list[i]) >= 5)
                    dau++;
                else
                    rot++;

                if ((i + 1) % 4 == 0)
                    sb.AppendLine();
            }

            dsMhDiem.Text = sb.ToString();

            if (list.Count > 1)
            {
                double diemtbmon = (tbmon / (list.Count - 1));
                dtb.Text = Math.Round(diemtbmon, 2).ToString();
            }
            else dtb.Text = mindiem.ToString();
                thap_nhat.Text = mindiem.ToString();
            cao_nhat.Text = maxdiem.ToString();
            mon_dau.Text = dau.ToString();
            mon_rot.Text = rot.ToString();

            if (double.Parse(dtb.Text) >= 8 && mindiem >= 6.5)
            {
                  hoc_luc.Text = "Giỏi";
            }
            else if (double.Parse(dtb.Text) >= 6.5&&mindiem >= 5)
            {
                    hoc_luc.Text = "Khá";
            }
            else if (double.Parse(dtb.Text) >= 5 && mindiem >= 3.5)
            {
                    hoc_luc.Text = "Trung Bình";
            }
            else if (double.Parse(dtb.Text) >= 3.5 && mindiem >= 2)
            {
                hoc_luc.Text = "Yếu";
            }
            else hoc_luc.Text = "Kém";
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void cao_nhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            dsDiem.Text = dsMhDiem.Text = dtb.Text = cao_nhat.Text = thap_nhat.Text = mon_dau.Text = mon_rot.Text = hoc_luc.Text = null;
        }

        private void thap_nhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
