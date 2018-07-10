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
    public partial class distance : Form
    {
        public distance()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        Double x1 = 0;
        Double y1 = 0;
        Double x2 = 0;
        Double y2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Double.Parse(textBox1.Text);
            y1 = Double.Parse(textBox2.Text);
            x2 = Double.Parse(textBox3.Text);
            y2 = Double.Parse(textBox4.Text);

            textBox5.Text = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))).ToString();
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
