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
        private Sardine sardine;
        private Muraenidae muraenidae;
        private Anglerfish anglerfish;

        private int Timerlimit = 60;
        private int lapTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            const int sardineSpeed = 2;
            const int muraenidaeSpeed = 1;
            const int angerfishSpeed = 1;

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            muraenidae = new Muraenidae(x, y, muraenidaeSpeed, pictureBox1);
            x = pictureBox5.Location.X;
            y = pictureBox5.Location.Y;
            sardine = new Sardine(x, y, sardineSpeed, pictureBox5);

            x = pictureBox8.Location.X;
            y = pictureBox8.Location.Y;
            anglerfish = new Anglerfish(x, y, angerfishSpeed, pictureBox8);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void MoveFish()
        {

            sardine.Run(out int x1, out int y1);
            muraenidae.Run(out int x2, out int y2);
            if(isNight == true)
            {
                muraenidae.Speed = 0;
            }
            else if(isDaytime == true)
            {
                muraenidae.Speed = 1;
            }
            anglerfish.Run(out int x3, out int y3);

            sardine.PictureMove(x1, y1, sardine.isFish);
            
            muraenidae.PictureMove(x2, y2, muraenidae.isFish);
            
            anglerfish.PictureMove(x3, y3, anglerfish.isFish);

            sardine.isFish = false;
            muraenidae.isFish = false;
            anglerfish.isFish = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lapTime++;
            Timerlimit--;
            ChangeBackground();

            label1.Text = "残り時間：" + Timerlimit;
            if(Timerlimit == 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("終了");
            }

        }

        public bool isDaytime = true;
        public bool isNight = false;

        private void ChangeBackground()
        {
            if (lapTime <= 10)
            {
                this.BackColor = Color.SteelBlue;
                isDaytime = true;
                isNight = false;
            }
            else if(lapTime <= 15)
            {
                this.BackColor = Color.MidnightBlue;
                isDaytime = false;
                isNight = true;
            }
            else
            {
                lapTime = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MoveFish();
            label2.Text = "得点：" + point;
        }

        public int point = 0;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (pictureBox5.Location.X - pictureBox6.Location.X + 120 <= 30 && pictureBox5.Location.X - pictureBox6.Location.X + 120 >= -30)
            {
                if (e.KeyCode <= Keys.D3 && e.KeyCode >= Keys.D0 && isDaytime == true)
                {
                    sardine.isFish = true;
                    point  += 1;//イワシ1点
                }
            }
            
            if (pictureBox1.Location.X - pictureBox7.Location.X + 230 <= 30 && pictureBox1.Location.X - pictureBox7.Location.X + 230 >= -30)
            {
                if (e.KeyCode >= Keys.D7 && e.KeyCode <= Keys.D9 &&isDaytime == true)
                {
                    muraenidae.isFish = true;
                    point += 3;//ウツボ３点
                }

            }
            
            if (pictureBox8.Location.X - pictureBox4.Location.X + 130 <= 30 && pictureBox8.Location.X - pictureBox4.Location.X + 130 >= -30)
            {
                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                {
                    anglerfish.isFish = true;
                    point += 5;//アンコウ５点
                }
            }
            
            
        }

    }
}
