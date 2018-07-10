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
    public partial class pythagorean : Form
    {
        public pythagorean()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        Double avalue = 0;
        Double bvalue = 0;
        Double cvalue = 0;
 
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
                textBox3.Text = (Math.Sqrt((avalue * avalue) + (bvalue * bvalue))).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void pythagorean_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox6.Text == "")
            {
                return;
            }
            else
            {
                avalue = Double.Parse(textBox6.Text);
                cvalue = Double.Parse(textBox4.Text);
                textBox5.Text = (Math.Sqrt((cvalue * cvalue) - (avalue * avalue))).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || textBox7.Text == "")
            {
                return;
            }
            else
            {
                bvalue = Double.Parse(textBox8.Text);
                cvalue = Double.Parse(textBox7.Text);
                textBox9.Text = (Math.Sqrt((cvalue * cvalue) - (bvalue * bvalue))).ToString();
            }
        }
    }
}
