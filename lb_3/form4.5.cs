using System;
using System.Windows.Forms;

namespace lb_3
{
    public partial class form4_5 : Form
    {
        public string sls;
        public form4_5(string sls, Form4 ff_4)
        {
            this.sls = sls;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(sls,this);
            f5.ShowDialog();
        }
    }
}