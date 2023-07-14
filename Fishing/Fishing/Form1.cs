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
        private int duration = 60;
        private int duration2 = 60;
        private utubo Utubo;
        private anko Anko;
        private iwasi Iwasi;
        private int n = 0;
        private sakana[] fishs;
        private int time1 = 60;
        private string AP = "Hiru";
        private PictureBox[] fishImages;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Movesakana();
            if(duration > 0)
            {
                duration--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movesakana();
            timer1.Start();
            timer2.Start();
        }
        private void Movesakana()
        {
            bool rc1 = Utubo.Run();
            bool rc2 = Anko.Run();
            bool rc3 = Iwasi.Run();
        }
        private void count_down(object sender, EventArgs e)
        {
            
        }

        private void count_down2(object sender, EventArgs e)
        {
            if (duration2 == 0)
            {
                StopFishs();
                timer2.Stop();
            }
            else if (duration2 > 0)
            {
                duration2--;
                label2.Text = duration2.ToString() + "秒";

                if (duration2 == 50 || duration2 == 35 || duration2 == 20 ||
                    duration2 == 5)
                {
                    this.BackColor = Color.Blue;
                }
                else if(duration2 == 45 || duration2 == 30 || duration2 == 15 )
                {
                    this.BackColor = Color.Aqua;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label4.Text = n + "点";
            int formSizeM = this.ClientSize.Width;

            const int AnkoSpeed = 10;
            const int UtuboSpeed = 10;
            const int IwasiSpeed = 20;
            //ウツボ
            int x = Utu.Location.X;
            int y = Utu.Location.Y;
            int distanceW = formSizeM - Utu.Size.Width;
            bool tabeta = false;
            Utubo = new utubo(x, y, UtuboSpeed, distanceW, tabeta, time1, Utu);
            //アンコウ
            int a = An.Location.X;
            int b = An.Location.Y;
            int distanceY = formSizeM - An.Size.Width;
            Anko = new anko(a, b, AnkoSpeed,distanceY, tabeta, time1, An);
            //イワシ
            int c = Iw.Location.X;
            int d = Iw.Location.Y;
            int distanceX = formSizeM - Iw.Size.Width;
            Iwasi = new iwasi(c, d, IwasiSpeed, distanceX, tabeta, time1, Iw);

            fishs = new sakana[3];
            fishs[0] = Iwasi;
            fishs[1] = Anko;
            fishs[2] = Utubo;

            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 100;

            timer2.Tick += new EventHandler(count_down2);
            timer2.Interval = 1000;

            fishImages = new PictureBox[] { Iw, An, Utu };
        }

        private void pictureBoxEsaS_Click(object sender, EventArgs e)
        {

        }
        private void StopFishs()
        {
            for(int i = 0; i < fishs.Length; i++)
            {
                fishs[i].isSwim = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (duration2 == 50 || duration2 == 35 || duration2 == 20 ||
                    duration2 == 5)
            {
                Utubo.YoruU();
                AP = "Night";
            }
            else if (duration2 == 45 || duration2 == 30 || duration2 == 15)
            {
                Utubo.Speed = 10;
                AP = "Hiru";
            }
        }
        private void Form1_KeyDone(object sender,KeyEventArgs e)
        {
            int EsaX1 = EsaS.Location.X;
            int EsaX2 = EsaM.Location.X;
            int EsaX3 = EsaL.Location.X;
            if (e.KeyCode <= Keys.NumPad3)
            {
                if ((Iwasi.PositionX - 30 <= EsaX1 && EsaX1 <= Iwasi.PositionX + 30) && AP == "Hiru")
                {
                    n += 1;
                    Iwasi.PositionX = -300;
                }
            }else if(e.KeyCode >= Keys.NumPad7)
            {
                if((Utubo.PositionX - 30 <= EsaX3 && EsaX3 <= Utubo.PositionX + 30)&& AP == "Hiru")
                {
                    n += 1;
                    Utubo.PositionX = -300;
                }
            }
            if(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                if (Anko.PositionX - 30 <= EsaX2 && Anko.PositionX + 30 >= EsaX2)
                {
                    n += 1;
                    Anko.PositionX = -300;
                }
            }
            label4.Text = n + "点";
        }

        private void Reset(PictureBox fishImage)
        {
            fishImage.Location = new Point(-300, fishImage.Location.Y);
        }
    }
}
