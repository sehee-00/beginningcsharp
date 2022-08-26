using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int carSpeed = 0;   //자동차 스피드

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carSpeed);
        }

        void moveline(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if (pictureBox_Car.Right > 0)
                    pictureBox_Car.Left += -5;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(pictureBox_Car.Right < 410 - pictureBox_Car.Width/2)
                    pictureBox_Car.Left += 5;
            }
            if(e.KeyCode == Keys.Up)
            {
                if(carSpeed < 15) 
                { 
                    carSpeed++;
                }
                pictureBox_Car.Top -= 5;
            }
            if(e.KeyCode == Keys.Down)
            {
                if(carSpeed > 3) 
                { 
                    carSpeed--;
                }
                //pictureBox_Car. += -5;
            }
        }
    }
}
