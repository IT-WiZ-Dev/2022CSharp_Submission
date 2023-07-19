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
        private int timer = 600;
        private int oneday = 150;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           int formSizeW = this.ClientSize.Width; //フォームのサイズ

            const int IwashiSpeed = 20; //イワシスピード
            const int UtsuboSpeed = 10; //ウツボスピード
            const int AnkouSpeed = 10; //アンコウスピード
            //イワシクラスインスタンス
            int x = pictureBoxiwashi.Location.X;
            int y = pictureBoxiwashi.Location.Y;
            iwashi = new Iwashi
                (x, y, IwashiSpeed, pictureBoxiwashi,formSizeW);
            
            //ウツボクラスインスタンス
            x = pictureBoxiutubo.Location.X;
            y = pictureBoxiutubo.Location.Y;
            utubo = new Utubo
                (x, y, UtsuboSpeed, pictureBoxiutubo,formSizeW);

            //アンコウクラスインスタンス
            x = pictureBoxankou.Location.X;
            y = pictureBoxankou.Location.Y;
            ankou = new Ankou
                (x, y, AnkouSpeed, pictureBoxankou,formSizeW);

            labelTime.Text = "";
            labelScore.Text = "";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MoveFish();
        }

        private void MoveFish()
        {
            iwashi.Swim(out int x1,out int y1);
            iwashi.PbMove(x1,y1);
            utubo.Swim(out int x2,out int y2);
            utubo.PbMove(x2,y2);
            ankou.Swim(out int x3,out int y3);
            ankou.PbMove(x3,y3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "残り時間:" + (timer / 10) + "秒";
            timer--;

            if(oneday >= 51) //昼間
            {
                oneday--;
            }
            else if(oneday == 50)//夜
            {
                iwashi.SleepDown();
                utubo.SleepDown();
                BackColor = Color.Black;
                oneday--;
            }
            else if(oneday == 0)
            {
                oneday = 150;
                iwashi.SleepUp();
                utubo.SleepUp();
                BackColor = Color.Blue;
            }else
            {
                oneday--;
            }

            if(timer == 0)
            {
                timer1.Stop();
                labelTime.Text = "終了";
            }
            else
            {
                MoveFish();
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                score += iwashi.Get(int.Parse(e.KeyChar.ToString()), pictureBoxesa_S);
                score += utubo.Get(int.Parse(e.KeyChar.ToString()), pictureBoxesa_M);
                score += ankou.Get(int.Parse(e.KeyChar.ToString()), pictureBoxesa_L);

                labelScore.Text = "得点：" + score;
            }
        }
    }
}
