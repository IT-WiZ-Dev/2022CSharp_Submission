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
        private Iwasi iwasi;
        private Utubo utubo;
        private Ankou ankou;
        private Sakana[] fishs;
        private int time1 = 60;
        private int iwasiSpeed = 20;
        private int utuboSpeed = 10;
        private int ankouSpeed = 10;
        private string AP = "hiru";
        private int n = 0;
        private PictureBox[] fishImages;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            //イワシクラスのインスタンス生成
            int x = pictureBoxiwashi.Location.X;
            int y = pictureBoxiwashi.Location.Y;
            int distanceW = formSizeW - pictureBoxiwashi.Size.Width;
            iwasi = new Iwasi
                (x, y, iwasiSpeed, distanceW, time1, pictureBoxiwashi);

            //ウツボクラスのインスタンス生成
            x = pictureBoxutubo.Location.X;
            y = pictureBoxutubo.Location.Y;
            distanceW = formSizeW - pictureBoxutubo.Size.Width;
            utubo = new Utubo
                (x, y, utuboSpeed, distanceW, time1, pictureBoxutubo);
            //アンコウクラスのインスタンス生成
            x = pictureBoxankou.Location.X;
            y = pictureBoxankou.Location.Y;
            distanceW = formSizeW - pictureBoxankou.Size.Width;
            ankou = new Ankou
                (x, y, ankouSpeed, distanceW, time1, pictureBoxankou);

            fishs = new Sakana[3];
            fishs[0] = iwasi;
            fishs[1] = ankou;
            fishs[2] = utubo;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 100;

            timer2.Tick += new EventHandler(count_down2);
            timer2.Interval = 1000;

            fishImages = new PictureBox[] { pictureBoxiwashi, pictureBoxankou, pictureBoxutubo };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //乗り物を進める
            Movesakana();

            timer1.Start();
            timer2.Start();
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
                label1.Text = duration2.ToString() + "秒";
                if (duration2 == 50 || duration2 == 35 || duration2 == 20 ||
                    duration2 == 5)
                {
                    this.BackColor = Color.MidnightBlue;
                }
                else if (duration2 == 45 || duration2 == 30 || duration2 == 15)
                {
                    this.BackColor = Color.SkyBlue;
                }
            }
        }

        private void Movesakana()
        {
            bool rc1 = iwasi.Run();
            bool rc2 = utubo.Run();
            bool rc3 = ankou.Run();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Movesakana();
            if (duration == 0)
            {
                // timer1.Stop();
            }
            else if (duration > 0)
            {
                duration--;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (duration2 == 50 || duration2 == 35 || duration2 == 20 ||
                duration2 == 5)
            {
                utubo.teisi();
                AP = "yoru";
            }
            else if (duration2 == 45 || duration2 == 30 || duration2 == 15)
            {
                utubo.saikai();
                AP = "hiru";
            }
        }

        private void StopFishs()
        {
            for (int i = 0; i < fishs.Length; i++)
            {
                fishs[i].isSwim = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int EsaX1 = esaS.Location.X;
            int EsaX2 = esaM.Location.X;
            int EsaX3 = esaL.Location.X;

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D3)
            {
                if (iwasi.PositionX - 30 <= EsaX1 && EsaX1 <= iwasi.PositionX + 30 && AP == "hiru")
                {
                    n += 1;
                    iwasi.PositionX = -300;
                    ResetFishImage(pictureBoxiwashi);
                }
            }
            else if (e.KeyCode >= Keys.D7 && e.KeyCode <= Keys.D9)
            {
                if (utubo.PositionX - 30 <= EsaX3 && EsaX3 <= utubo.PositionX + 30 && AP == "hiru")
                {
                    n += 1;
                    utubo.PositionX = -300;
                    ResetFishImage(pictureBoxutubo);
                }
            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (ankou.PositionX - 30 <= EsaX2 && EsaX2 <= ankou.PositionX + 30)
                {
                    n += 1;
                    ankou.PositionX = -300;
                    ResetFishImage(pictureBoxankou);
                }
            }
            
            label2.Text = n + "点";
        }
        private void ResetFishImage(PictureBox fishImage)
        {
            // 画像を初期位置に戻す
            fishImage.Location = new Point(-300, fishImage.Location.Y);
        }
    }
}

