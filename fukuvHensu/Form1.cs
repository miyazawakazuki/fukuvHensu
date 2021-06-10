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
        int vx =-10;
        int vy=-10;
       


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


            label1.Left += vx;
            label1.Top += vy;

            vx = Math.Abs(vx);

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }

            if (label1.Left+label1.Width < ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
           //MessageBox.Show("高さ" + ClientSize.Height);
        }
    }
}
