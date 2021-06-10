using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx;
        int vy;
        int speed;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            label1.Left += vx*speed;
            label1.Top += vy*speed;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = -10;
            vy = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 10;
            vy = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            vx = 0;
            vy = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
