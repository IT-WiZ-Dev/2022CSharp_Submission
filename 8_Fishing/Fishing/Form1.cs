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
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            int formSizeW = this.ClientSize.Width;
            iwashi = new Iwashi(x, y, IwashiSpeed, formSizeW, pictureBoxIwashi);
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new Utubo(x, y, UtuboSpeed, formSizeW, pictureBoxUtubo);
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new Ankou(x, y, AnkouSpeed, formSizeW, pictureBoxAnkou);
        }

        // 魚が泳ぐ
        private void SwimFish()
        {
            // 魚が泳ぎピクチャーボックスの位置を進める
            iwashi.Swim(out int x1, out int y1);
            iwashi.PictureMove(x1, y1);
            utubo.Swim(out int x2, out int y2);
            utubo.PictureMove(x2, y2);
            ankou.Swim(out int x3, out int y3);
            ankou.PictureMove(x3, y3);
        }

        //「スタートボタン」クリックのイベントハンドラ
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            // 魚が泳ぐ
            SwimFish();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = "残り " + (remainingTime / 10) + " 秒";

            if (isDayTime == true)
            {
                daytime--;
                if (daytime == 0)
                {
                    isDayTime = false;
                    iwashi.Sleep();
                    utubo.Sleep();
                    daytime = DayTime;
                    BackColor = Color.SteelBlue;
                }
            }
            else // 夜
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
                labelTime.Text = "ゲームオーバー";
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
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaS);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaL);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaM);
                labelScore.Text = "得点：" + score;
            }
        }
    }
}
