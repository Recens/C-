using System;
using System.Windows.Forms;

namespace lb_3
{
    public partial class Form2 : Form
    {
        public Form2(Form1 f_1)
        {
            InitializeComponent();
            f_1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }
    }
}