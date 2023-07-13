using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai8syouR
{
    public partial class Form1 : Form
    {
        private bool DayTime = true;      // 昼間はtrue;
        private int daymoning = 100;          // 昼間
        private int night = 50;            //夜にかける
        private int score = 0;
        private iwasi Iwasi;
        private ankimo Ankimo;
        private utubo Utubo;
        private int limittime = 600;

        public Form1()
        {
            InitializeComponent();
            this.KeyPress += Form1_KeyPress;//ChatGBTです
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int formS = this.ClientSize.Width;
            const int IwasiSpeed = 20;
            const int AnkimoSpeed = 10;
            const int UtuboSpeed = 10;

            int x = pictureBoxiwasi.Location.X;
            int y= pictureBoxiwasi.Location.Y;
            Iwasi = new iwasi(x, y, IwasiSpeed, formS, pictureBoxiwasi);


            x=pictureBoxankou.Location.X;
            y= pictureBoxankou.Location.Y;
            Ankimo = new ankimo(x, y, AnkimoSpeed, formS, pictureBoxankou);

            x=pictureBoxutubo.Location.X;
            y= pictureBoxutubo.Location.Y;
            Utubo = new utubo(x, y, UtuboSpeed, formS, pictureBoxutubo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            swim();
            score = 0;
            label2.Text = "得点:"+score;
        }
        private void swim()
        {
            int x;
           int y;
           Iwasi.Swim(out x,out  y);
            Iwasi.move(x, y);
            Ankimo.Swim(out x,out  y);
            Ankimo.move(x, y);
            Utubo.Swim(out x,out y); 
            Utubo.move(x,y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            limittime = limittime - 1;
            label1.Text = "残り時間："+(limittime/10)+"秒";
            if (DayTime == true)
            {
                daymoning = daymoning - 1;
                if (daymoning == 0)
                {
                    DayTime = false;
                    Iwasi.Sleep();
                    Utubo.Sleep();
                    this.BackColor = Color.Navy;
                    night = 50;
                }
            }
            else
            {
                night = night - 1;
                if (night == 0)
                {
                    DayTime = false;
                    Iwasi.WakeUp();
                    Utubo.WakeUp();
                    this.BackColor = Color.CornflowerBlue;
                    daymoning = 100;
                }
                
            }
            if (limittime == 0)
            {
                timer1.Stop();
                label1.Text = "終了";
            }
            else
            {
                swim();
            }
          
        }
        private void Form1_KeyPress(object sender,KeyPressEventArgs e)
        {
            
            if (e.KeyChar>='0'&& e.KeyChar<='9')
            {
                score = score + Iwasi.tabelu(int.Parse(e.KeyChar.ToString()), pictureBoxesaS);
                score = score + Ankimo.tabelu(int.Parse(e.KeyChar.ToString()),pictureBoxesa);
                score = score + Utubo.tabelu(int.Parse(e.KeyChar.ToString()), pictureBoxesaL);
                label2.Text = "得点:" +score;
            }
           
        }

    }
}
