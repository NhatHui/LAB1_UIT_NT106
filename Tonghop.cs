using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private Bai1 bai1Form;
        private Bai2 bai2Form;
        private Bai3 bai3Form;
        private bai4 bai4Form;
        private Bai5 bai5Form;

        public MainForm()
        {
            InitializeComponent();
            bai1Form = new Bai1();
            bai2Form = new Bai2();
            bai3Form = new Bai3();
            bai4Form = new bai4();
            bai5Form = new Bai5();
        }

        //private void btnSwitchToBai1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Switching to Bai1");
        //    this.Hide();
        //    bai1Form.Show();
        //}

        //private void btnSwitchToBai2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Switching to Bai2");
        //    this.Hide();
        //    bai2Form.Show();
        //}

        //private void btnSwitchToBai3_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Switching to Bai3");
        //    this.Hide();
        //    bai3Form.Show();
        //}

        //private void btnSwitchToBai4_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Switching to Bai4");
        //    this.Hide();
        //    bai4Form.Show();
        //}

        //private void btnSwitchToBai5_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Switching to Bai5");
        //    this.Hide();
        //    bai5Form.Show();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Switching to Bai4");
            //this.Hide();
            bai4Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Switching to Bai1");
            //this.Hide();
            bai1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Switching to Bai2");
            //this.Hide();
            bai2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Switching to Bai3");
            //this.Hide();
            bai3Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Switching to Bai5");
            //this.Hide();
            bai5Form.Show();
        }
    }
}