using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fising
{
    public partial class Form1 : Form
    {
        private Iwashi iwashi;
        private Utubo utubo;
        private Ankou ankou;
        private int remainingTime = 600;
        private bool isDayTime = true;
        private int daytime = DayTime;
        private int night = NightTime;
        private int score = 0;
        private const int IwashiSpeed = 20;
        private const int UtuboSpeed = 10;
        private const int AnkouSpeed = 10;
        private const int DayTime = 100;
        private const int NightTime = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;
            int x = pictureBox3.Location.X;
            int y = pictureBox3.Location.Y;
            iwashi = new Iwashi(x, y, IwashiSpeed, formSizeW, pictureBox3);
            x = pictureBox4.Location.X;
            y = pictureBox4.Location.Y;
            utubo = new Utubo(x, y, UtuboSpeed, formSizeW, pictureBox4);
            x = pictureBox5.Location.X;
            y = pictureBox5.Location.Y;
            ankou = new Ankou(x, y, AnkouSpeed, formSizeW, pictureBox5);
        }

        private void SwimFish()
        {
            iwashi.Swim(out int x1, out int y1);
            iwashi.PictureMove(x1, y1);
            utubo.Swim(out int x2, out int y2);
            utubo.PictureMove(x2, y2);
            ankou.Swim(out int x3, out int y3);
            ankou.PictureMove(x3, y3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            SwimFish();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label1.Text = "残り時間：" + (remainingTime / 10) + "秒";

            if (isDayTime == true)
            {
                daytime--;
                if (daytime == 0)
                {
                    isDayTime = false;
                    iwashi.Sleep();
                    utubo.Sleep();
                    daytime = DayTime;
                    BackColor = Color.Navy;
                }
            }
            else
            {
                night--;
                if (night == 0)
                {
                    isDayTime = true;
                    iwashi.WakeUp();
                    utubo.WakeUp();
                    night = NightTime;
                    BackColor = Color.CornflowerBlue;
                }
            }

            if (remainingTime / 10 == 0)
            {
                timer1.Stop();
                label1.Text = "ゲームオーバー";
            }
            else
            {
                SwimFish();
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxS);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxL);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxM);

                label2.Text = "得点：" + score;
            }
        }
    }
}
