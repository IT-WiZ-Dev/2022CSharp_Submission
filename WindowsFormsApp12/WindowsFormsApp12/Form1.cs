using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        private Iwasi iwasi;
        private Utubo utubo;
        private Anko anko;
        private int remainingTime = 600;
        private bool isDayTime;
        private int daytime = 100;
        private int night = 50;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            //魚のインスタンスを作成
            int x = picture_Iwasi.Location.X;
            int y = picture_Iwasi.Location.Y;
            iwasi = new Iwasi(x, y, 20, formSizeW, picture_Iwasi);
            x = picture_Utubo.Location.X;
            y = picture_Utubo.Location.Y;
            utubo = new Utubo(x, y, 10, formSizeW,picture_Utubo);
            x = picture_Anko.Location.X;
            y = picture_Anko.Location.Y;
            anko = new Anko(x, y, 10, formSizeW, picture_Anko);
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            swiming();
        }

        private void swiming()
        {
            int x, y;

            //イラストを進める
            iwasi.Swiming(out x, out y);
            iwasi.Move(x, y);
            utubo.Swiming(out x, out y);
            utubo.Move(x, y);
            anko.Swiming(out x, out y);
            anko.Move(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label1.Text = "残り時間：" + (remainingTime / 10) + "秒";
            
            if(isDayTime == true)
            {
                daytime--;
                if(daytime == 0)
                {
                    isDayTime = false;
                    iwasi.Sleep();
                    utubo.Sleep();
                    daytime = 100;
                    this.BackColor = Color.Navy;
                }
            }
            else
            {
                night--;
                if(night == 0)
                {
                    isDayTime = true;
                    iwasi.WakeUp();
                    utubo.WakeUp();
                    night = 50;
                    this.BackColor = Color.CornflowerBlue;
                }
            }

            if(remainingTime / 10 == 0)
            {
                timer1.Stop();
                label1.Text = "ゲームオーバー";

            }
            else
            {
                swiming();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字キーが押された時の処理
            if(e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                //餌を食べる
                score += iwasi.Fishing(int.Parse(e.KeyChar.ToString()), picture_esaS);
                score += utubo.Fishing(int.Parse(e.KeyChar.ToString()), picture_esaM);
                score += anko.Fishing(int.Parse(e.KeyChar.ToString()), picture_esaL);

                label2.Text = "得点：" + score;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
