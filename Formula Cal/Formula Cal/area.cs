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
    public partial class area : Form
    {
        Double avalue = 0;
        Double bvalue = 0;
        public area()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                textBox2.Clear();
                avalue = Double.Parse(textBox1.Text);
                textBox4.Text = (avalue * avalue).ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                bvalue = Double.Parse(textBox2.Text);
                textBox5.Text = (.5 * (avalue - bvalue)).ToString();

            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox1.Text);
                textBox3.Text = (Math.PI * (avalue * avalue)).ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void area_Load(object sender, EventArgs e)
        {

        }
    }
}
