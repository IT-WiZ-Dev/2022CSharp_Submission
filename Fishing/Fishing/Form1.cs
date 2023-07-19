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
        private iwasi Iwasi;
        private utubo Utubo;
        private ankou Ankou;
        private int countdown = 600;
        private int suncount = 100;
        private int mooncount = 50;
        private const int IwasiSpeed = 20;
        private const int UtuboSpeed = 10;
        private const int AnkouSpeed = 10;
        private bool Intime = true;
        private int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formsize= this.ClientSize.Width;



            int x = pictureIwasi.Location.X;
            int y = pictureIwasi.Location.Y;
            Iwasi = new iwasi(x, y,IwasiSpeed,formsize,pictureIwasi);

            x = pictureUtubo.Location.X;
            y = pictureUtubo.Location.Y;
            Utubo = new utubo(x, y, UtuboSpeed, formsize, pictureUtubo);

            x = pictureAnkou.Location.X;
            y = pictureAnkou.Location.Y;
            Ankou = new ankou(x, y, AnkouSpeed, formsize, pictureAnkou);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            label1.Text = "残り時間 : " + ( countdown/10);

            if (countdown == 0)
            {
                    timer1.Stop();
                    label1.Text = "GameOver";
            }
            else
            {
                Move();
            }

            if (Intime == true)
            {
                suncount--;

                if (suncount == 0)
                {
                    //夜
                    Intime = false;
                    suncount = 100;
                    BackColor = Color.MidnightBlue;
                    Utubo.Sleep();
                    Iwasi.Sleep();
                }

            }else
            {
                mooncount--;

                if (mooncount == 0)
                {
                    //朝
                    Intime=true;
                    mooncount = 50;
                    BackColor = Color.DeepSkyBlue;
                    Utubo.WakeUp();
                    Iwasi.WakeUp();

                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            Move();
        }

        private void Move()
        {
            Iwasi.Run(out int x1, out int y1);
            Iwasi.PictureMove(x1,y1);

            Utubo.Run(out int x2, out int y2);
            Utubo.PictureMove(x2, y2);

            Ankou.Run(out int x3, out int y3);
            Ankou.PictureMove(x3, y3);

        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字キーを押下した
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                // 餌を食べる
                score += Iwasi.Eat(int.Parse(e.KeyChar.ToString()), pictureS);
                score += Utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureM);
                score += Ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureL);


                label3.Text = "得点：" + score;
            }


        }
    }
}
