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
    public partial class basic : Form
    {
        public basic()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        Double avalue = 0;
        Double bvalue = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox3.Text = (avalue + bvalue).ToString();
                label2.Text = "+";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox3.Text = (avalue - bvalue).ToString();
                label2.Text = "-";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox3.Text = (avalue / bvalue).ToString();
                label2.Text = "/";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox3.Text = (avalue * bvalue).ToString();
                label2.Text = "*";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_Load(object sender, EventArgs e)
        {

        }
    }
}
