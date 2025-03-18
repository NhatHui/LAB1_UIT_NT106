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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsBinary(string input)
            {
                return input.All(c => c == '0' || c == '1');
            }

            bool IsHexadecimal(string input)
            {
                return input.All(c => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f'));
            }

            int GetBaseFromComboBox(ComboBox comboBox)
            {
                string selectedItem = comboBox.SelectedItem?.ToString();
                switch (selectedItem)
                {
                    case "Decimal":
                        return 10;
                    case "Binary":
                        return 2;
                    case "Hexadecimal":
                        return 16;
                    default:
                        return 0;
                }
            }

            int baseFrom = GetBaseFromComboBox(comboBox1);
            int baseTo = GetBaseFromComboBox(comboBox2);

            if (baseFrom == 0 || baseTo == 0)
            {
                MessageBox.Show("Vui lòng chọn hệ cơ số từ cả hai ComboBox.");
                return;
            }

            int number;
            if (int.TryParse(textBox1.Text, out number) || (IsHexadecimal(textBox1.Text) && baseFrom == 16))
            {
                string output = "";

                if (baseFrom == 10 && baseTo == 2)
                {
                    output = Convert.ToString((int)number, 2);
                }
                else if (baseFrom == 2 && baseTo == 10)
                {
                    if (!IsBinary(textBox1.Text))
                    {
                        MessageBox.Show("Nhập sai định dạng Binary");
                        return;
                    }
                    output = Convert.ToInt32(textBox1.Text, 2).ToString();
                }
                else if (baseFrom == 10 && baseTo == 16)
                {
                    output = Convert.ToString((int)number, 16).ToUpper();
                }
                else if (baseFrom == 16 && baseTo == 10)
                {
                    if (!IsHexadecimal(textBox1.Text))
                    {
                        MessageBox.Show("Nhập sai định dạng Hexadecimal");
                        return;
                    }
                    output = Convert.ToInt32(textBox1.Text, 16).ToString();
                }
                else if (baseFrom == 2 && baseTo == 16)
                {
                    if (!IsBinary(textBox1.Text))
                    {
                        MessageBox.Show("Nhập sai định dạng Binary");
                        return;
                    }
                    output = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16).ToUpper();
                }
                else if (baseFrom == 16 && baseTo == 2)
                {
                    if (!IsHexadecimal(textBox1.Text))
                    {
                        MessageBox.Show("Nhập sai định dạng Hexadecimal");
                        return;
                    }
                    output = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);
                }
                else if (baseFrom == baseTo)
                {
                    output = textBox1.Text;
                }

                textBox2.Text = output;
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
