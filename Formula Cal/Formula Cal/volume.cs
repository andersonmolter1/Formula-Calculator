using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula_Cal
{
    public partial class volume : Form
    {
        public volume()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        Double avalue = 0;
        Double bvalue = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox3.Text = (avalue * avalue * avalue).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                textBox5.Text = ((4 / 3) * Math.PI * (avalue * avalue * avalue)).ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox4.Text = ((1 / 3) * avalue * bvalue).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }
    }
}
