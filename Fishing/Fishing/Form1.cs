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
    public partial class FormGameSet : Form
    {
        private Iwasi iwasi;
        private Utubo utubo;
        private Ankou ankou;
        private int duration = 60;
        private int duration2 = 60;
        private string enviroment = "hiru";
        private Fish[] fishs;
        public FormGameSet()
        {
            InitializeComponent();
        }

        private void FormGameSet_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            const int IwasiSpeed = 20;
            const int UtuboSpeed = 10;
            const int AnkouSpeed = 10;

            int x = pictureBoxIwasi.Location.X;
            int y = pictureBoxIwasi.Location.Y;
            int distanceW = formSizeW - pictureBoxIwasi.Size.Width;
            iwasi = new Iwasi(x,y,IwasiSpeed,distanceW,pictureBoxIwasi);

             x = pictureBoxUtubo.Location.X;
             y = pictureBoxUtubo.Location.Y;
             distanceW = formSizeW - pictureBoxUtubo.Size.Width;
             utubo = new Utubo(x, y, UtuboSpeed, distanceW, pictureBoxUtubo);

             x = pictureBoxAnkou.Location.X;
             y = pictureBoxAnkou.Location.Y;
             distanceW = formSizeW - pictureBoxAnkou.Size.Width;
             ankou = new Ankou(x, y, AnkouSpeed, distanceW, pictureBoxAnkou);

            fishs = new Fish[3];
            fishs[0] = iwasi;
            fishs[1] = ankou;
            fishs[2] = utubo;

            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer2.Tick += new EventHandler(count_down2);
            timer2.Interval = 100;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MoveFish();
            timer1.Start();
            timer2.Start();
        }

        private void MoveFish()
        {
            bool rc1 = iwasi.swim();
            bool rc2 = ankou.swim();
            bool rc3 = utubo.swim();
        }

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();
                Stopfish();
            }
            else if (duration > 0)
            {
                duration--;
                labelTime.Text ="残り時間：" + duration.ToString() + "秒";

                if (duration > 50 || (duration <= 45 && duration > 35) ||
                    (duration >20 && duration <= 30) || (duration > 5 && duration <= 15))
                {
                    this.BackColor = Color.MediumBlue;
                    enviroment = "hiru";
                    utubo.Speed = 10;
                }
                else
                {
                    this.BackColor = Color.MidnightBlue;
                    enviroment = "yoru";
                    utubo.Speed = 0;
                }
            }
        }
        private void Stopfish()
        {
            for(int i = 0; i < fishs.Length; i++)
            {
                fishs[i].IsSwim = false;
            }
        }

        private void count_down2(object sender,EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MoveFish();
            if(duration > 0)
            {
                duration2--;
            }
        }
        private int score = 0; // 得点


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int EsaX1 = pictureBoxEsaS.Location.X;
            int EsaX2 = pictureBoxEsaM.Location.X;
            int EsaX3 = pictureBoxEsaL.Location.X;

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D3)
            {
               if (iwasi.PositionX - 30 <= EsaX1 && EsaX1 <= iwasi.PositionX + 30 && enviroment == "hiru") 
                {
                    score += 1;
                    iwasi.PositionX = -300;
                    ResetFish(pictureBoxIwasi);
                }
            }
            else if (e.KeyCode >= Keys.D7 && e.KeyCode <= Keys.D9)
            {
                if (utubo.PositionX - 30 <= EsaX3 && EsaX3 <= utubo.PositionX + 30 && enviroment == "hiru")
                {
                    score += 1;
                    utubo.PositionX = -300;
                    ResetFish(pictureBoxUtubo);
                }
            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (ankou.PositionX - 30 <= EsaX2 && EsaX2 <= ankou.PositionX + 30)
                {
                    score += 1;
                    ankou.PositionX = -300;
                    ResetFish(pictureBoxAnkou);
                }
            }

            labelScore.Text = score + "点";
        }
        
        private void ResetFish(PictureBox fishImage)
        {
            fishImage.Location = new Point(-300, fishImage.Location.Y);
        }
    }
}
