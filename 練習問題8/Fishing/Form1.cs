using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
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

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            int x = pictureBox9.Location.X;
            int y = pictureBox9.Location.Y;
            iwashi = new Iwashi(x, y, IwashiSpeed, formSizeW, pictureBox9);
            x = pictureBox7.Location.X;
            y = pictureBox7.Location.Y;
            utubo = new Utubo(x, y, UtuboSpeed, formSizeW, pictureBox7);
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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            SwimFish();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label1.Text = "残り時間：" + (remainingTime / 10) + "秒";

            if (isDayTime == true)  // 昼間
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

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBox8);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBox6);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBox4);

                label2.Text = "得点：" + score;
            }
        }
    }
}
