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
    public partial class FormGame : Form
    {
        private Iwashi iwashi;
        private Utsubo utsubo;
        private Anko anko;
        private bool isDay = true;
        private int day = 100;
        private int night = 50;
        private int score = 0;
        private const int IwashiSpeed = 20;
        private const int UtsuboSpeed = 10;
        private const int AnkoSpeed = 10;
        private int timeLimit = 600;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            //イワシクラスのインスタンス生成
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwashi(x, y, IwashiSpeed, formSizeW, pictureBoxIwashi);

            //ウツボクラスのインスタンス生成
            x = pictureBoxUtsubo.Location.X;
            y = pictureBoxUtsubo.Location.Y;
            utsubo = new Utsubo(x, y, UtsuboSpeed, formSizeW, pictureBoxUtsubo);

            //アンコウクラスのインスタンス生成
            x = pictureBoxAnko.Location.X;
            y = pictureBoxAnko.Location.Y;
            anko = new Anko(x, y, AnkoSpeed, formSizeW, pictureBoxAnko);
        }


        private void Swim()
        {
            iwashi.Swim(out int x1, out int y1);
            iwashi.PictureMove(x1, y1);
            utsubo.Swim(out int x2, out int y2);
            utsubo.PictureMove(x2, y2);
            anko.Swim(out int x3, out int y3);
            anko.PictureMove(x3, y3);
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

            Swim();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLimit--;
            labelTimeLimit.Text = "残り時間：" + (timeLimit / 10) + "秒";

            if(isDay == true)
            {
                day--;
                if(day == 0)
                {
                    isDay = false;
                    iwashi.Sleep();
                    utsubo.Sleep();
                    day = 100;
                    BackColor = Color.SteelBlue;
                }
            }
            else
            {
                night--;
                if(night == 0)
                {
                    isDay = true;
                    iwashi.WakeUp();
                    utsubo.WakeUp();
                    night = 50;
                    BackColor = Color.LightSkyBlue;
                }
            }

            if(timeLimit / 10 == 0)
            {
                timer1.Stop();
                labelTimeLimit.Text = "ゲームオーバー";
            }
            else
            {
                Swim();
            }
        }

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                score += iwashi.EatFeed(int.Parse(e.KeyChar.ToString()), pictureBoxFeedS);
                score += utsubo.EatFeed(int.Parse(e.KeyChar.ToString()), pictureBoxFeedL);
                score += anko.EatFeed(int.Parse(e.KeyChar.ToString()), pictureBoxFeedM);
                labelScore.Text = "得点：" + score;
            }
        }
    }
}
