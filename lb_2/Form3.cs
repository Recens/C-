using System;
using System.Windows.Forms;

namespace lb_2
{
    public partial class Form3 : Form
    {
        public Form3(Form2 form2)
        {
            InitializeComponent();
            form2.Visible = false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}