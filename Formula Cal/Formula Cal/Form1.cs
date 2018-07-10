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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basic go = new basic();
            go.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pythagorean pytha = new pythagorean();
            pytha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            volume vol = new volume();
            vol.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            distance dist = new distance();
            dist.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quad quadd = new quad();
            quadd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            area areaa = new area();
            areaa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            midpoint mid = new midpoint();
            mid.Show();
        }

       
    }
}
