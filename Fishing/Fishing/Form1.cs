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
        private int reTime = 600;
        private bool isDayTime = true;
        private int midday = 100;
        private int night = 50;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            int x = pictureBoxiwashi.Location.X;
            int y = pictureBoxiwashi.Location.Y;
            iwashi = new Iwashi(x, y, 20, formSizeW, pictureBoxiwashi);
            x = pictureBoxutubo.Location.X;
            y = pictureBoxutubo.Location.Y;
            utubo = new Utubo(x, y, 10, formSizeW, pictureBoxutubo);
            x = pictureBoxankou.Location.X;
            y = pictureBoxankou.Location.Y;
            ankou = new Ankou(x, y, 10, formSizeW, pictureBoxankou);

            label1.Text = "残り時間：60秒";
            label2.Text = "得点：";
            this.BackColor = Color.CornflowerBlue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            swim();
        }

        private void swim()
        {
            int x, y;

            iwashi.Swim(out x, out y);
            iwashi.Move(x, y);
            utubo.Swim(out x, out y);
            utubo.Move(x, y);
            ankou.Swim(out x, out y);
            ankou.Move(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reTime--;
            label1.Text = "残り時間：" + (reTime / 10) + "秒";

            if(isDayTime == true)
            {
                midday--;
                if(midday == 0)
                {
                    isDayTime = false;
                    iwashi.Sleep();
                    utubo.Sleep();
                    midday = 100;
                    this.BackColor = Color.Navy;
                }
            }
            else
            {
                night--;
                if(night == 0)
                {
                    isDayTime = true;
                    iwashi.WakeUp();
                    utubo.WakeUp();
                    night = 50;
                    this.BackColor = Color.CornflowerBlue;
                }
            }

            if(reTime / 10 == 0)
            {
                timer1.Stop();
                label1.Text = "ゲームオーバー";
            }
            else
            {
                swim();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxesaS);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxesaL);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxesaM);

                label2.Text = "得点：" + score;
            }
        }
    }
}
