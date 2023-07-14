using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P304
{
    public partial class Form1 : Form
    {
        private Iwasi iwasi;
        private Utubo utubo;
        private Ankou ankou;

        private int score = 0;
        private int time = 600;

        private bool yoruhiru = true;
        private int hiruTime = 100;
        private int yoruTime = 50;
        private int timeCnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            const int IwasiSpeed = 20;
            int x = pictureBoxIwasi.Location.X;
            int y = pictureBoxIwasi.Location.Y;
            iwasi = new Iwasi(x, y, IwasiSpeed, formSizeW, pictureBoxIwasi);


            const int UtuboSpeed = 10;
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new Utubo(x, y, UtuboSpeed, formSizeW, pictureBoxUtubo);

            const int AnkouSpeed = 10;
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new Ankou(x, y, AnkouSpeed, formSizeW, pictureBoxAnkou);
        }
        


        private void MoveFish()
        {
            iwasi.Run(out int x1, out int y1);
            iwasi.PrictureMove(x1, y1);

            utubo.Run(out int x2, out int y2);
            utubo.PrictureMove(x2, y2);

            ankou.Run(out int x3, out int y3);
            ankou.PrictureMove(x3, y3);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            MoveFish();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            timeCnt++;
            labelTime.Text = "残り時間：" + (time / 10) + "秒";
            if (yoruhiru)
            {
                if (timeCnt == hiruTime)
                {
                    timeCnt = 0;
                    yoruhiru = false;
                    iwasi.sleep();
                    utubo.sleep();
                    BackColor = Color.Navy;
                }
            }
            else
            {
                if (timeCnt == yoruTime)
                {
                    timeCnt = 0;
                    yoruhiru = true;
                    iwasi.okiru();
                    utubo.okiru();
                    BackColor = Color.Blue;
                }
            }
            MoveFish();
            if (time == 0)
            {
                labelTimeup.Text = "タイムアップです！";
                timer1.Stop();
             }

            

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                score += iwasi.Eat(int.Parse(e.KeyChar.ToString()), pictureBox1);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBox2);
                score += ankou.Eat(pictureBox3);

                labelPoint.Text = "得点：" + score;
            }
        }

    }
}
