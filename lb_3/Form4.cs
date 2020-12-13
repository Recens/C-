using System;
using System.Windows.Forms;

namespace lb_3
{
    
    public partial class Form4 : Form
    {
        private int count = 0;
        public string sls;
        public Form4(string sls, Form3 f_3)
        {
            this.sls = sls;
            f_3.Visible = false;
            InitializeComponent();
            listBox1.Items.Add("Yes");
            listBox1.Items.Add("No");
            listBox2.Items.Add("Yes");
            listBox2.Items.Add("No");
            listBox3.Items.Add("Yes");
            listBox3.Items.Add("No");

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Yes")
            {
                count++;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Yes")
            {
                count++;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Yes")
            {
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5(sls, this);
            f5.ShowDialog();
            this.Hide();
            
        }
    }
}