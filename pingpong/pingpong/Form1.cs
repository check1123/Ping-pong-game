using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingpong
{
    public partial class Form1 : Form
    {
        int ballx = 10;
        int bally = 10;
        int player1 = 0;
        int player2 = 0;
        int timer = 30;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox2.Bounds))
                ballx = -ballx;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pictureBox2.Top -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBox2.Top += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox3.Top -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox3.Top += 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left += ballx;
            pictureBox4.Top += bally;

            if (pictureBox4.Location.Y > 460)
            {
                bally = -bally;
            }
            if (pictureBox4.Location.X>800)
            {
                ballx = -ballx;
                player1++;
                label1.Text=player1.ToString();
            }
            if(pictureBox4.Location.X<0)
            {
                ballx = -ballx;
                player2++;
                label2.Text = player2.ToString();
            }
            if (pictureBox4.Location.Y < 0)
            {
                bally = -bally;
            }
            if (pictureBox4.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                ballx = -ballx;
            }
            if(pictureBox4.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                ballx = -ballx;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer--;

            label3.Text = (timer / 60) + " : " + (timer % 60);
            if (timer==0)
            {
                timer1.Stop();
                timer2.Stop();
            }
        }
    }
}
