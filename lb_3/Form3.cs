using System;
using System.Windows.Forms;

namespace lb_3
{
    public partial class Form3 : Form
    {
        public string sls;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            form2.Visible = false;
            button1.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sls = textBox1.Text;
            button1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(sls, this);
            f4.ShowDialog();
            this.Hide();
            
        }
    }
}