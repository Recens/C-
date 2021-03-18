using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form3 : Form
    {
        public Form3(Form2 f_2)
        {
            InitializeComponent();
            f_2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}