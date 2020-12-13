using System;
using System.Windows.Forms;

namespace lb_3
{
    public partial class Form5 : Form
    {
        public string sls;
        public Form5(string sls, Form4 f_4)
        {
            f_4.Visible = false;
            this.sls = sls;
            InitializeComponent();
            label1.Text = "Thank "+this.sls+" for taking the survey." ;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}