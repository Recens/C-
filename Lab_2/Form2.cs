using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form2 : Form
    {
        public Form2(Form1 f_1)
        {
            InitializeComponent();
            f_1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
            this.Hide();
        }
    }
}