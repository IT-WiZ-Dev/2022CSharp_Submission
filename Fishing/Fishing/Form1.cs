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
    public partial class Fishing : Form
    {
        private Sardine s;
        private Moray m;
        private Anglerfish a;

        int hook_s;
        int hook_m;
        int hook_a;
        bool timezone;
        int time_n;
        int time_j;
        int point;
        const int SardlineSpeed = 20;
        const int MoraySpeed = 10;
        const int AnglerfishSpeed = 10;
        public Fishing()
        {
            InitializeComponent();
        }

        private void Fishing_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;
            hook_s = pictureBox3.Location.X + pictureBox3.Size.Width;
            hook_m = pictureBox2.Location.X + pictureBox2.Size.Width;
            hook_a = pictureBox1.Location.X + pictureBox1.Size.Width;

            int x = pictureBox8.Location.X;
            int y = pictureBox8.Location.Y;
            int distanceW = formSizeW;
            s = new Sardine(x, y, SardlineSpeed, distanceW, pictureBox8);

            x = pictureBox7.Location.X;
            y = pictureBox7.Location.Y;
            m = new Moray(x, y, MoraySpeed, distanceW, pictureBox7);

            x = pictureBox4.Location.X;
            y = pictureBox4.Location.Y;
            a = new Anglerfish(x, y, AnglerfishSpeed, distanceW, pictureBox4);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveFish();
            time_j++;
            if (time_j % 10 == 0)
            {
                time_n--;
            }
            label1.Text = "残り時間：" + time_n + "秒";
            if (timezone == true && time_j == 150)
            {
                time_j = 0;
                timezone = false;
                this.BackColor = System.Drawing.Color.DarkBlue;
            }
            else if (timezone == false && time_j == 50)
            {
                time_j = 0;
                timezone = true;
                this.BackColor = System.Drawing.Color.RoyalBlue;
            }
            if (time_n == 0)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timezone = true;
            time_n = 60;
            time_j = 0;
            point = 0;

            label1.Text = "残り時間：" + time_n + "秒";
            label2.Text = "得点：" + point;

            timer1.Start();
        }
        private void MoveFish()
        {
            bool rc1 = s.Run(out int x1, out int y1);
            bool rc3 = a.Run(out int x3, out int y3);

            s.PictureMove(x1, y1);
            a.PictureMove(x3, y3);

            if (timezone == true)
            {
                bool rc2 = m.Run(out int x2, out int y2);
                m.PictureMove(x2, y2);
            }
        }

        private void Fishing_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                int hit;
                if (e.KeyChar >= '1' && e.KeyChar <= '3' && timezone == true)
                {
                    hit = s.PositionX + pictureBox8.Size.Width - hook_s;
                    if (hit >= 0 && hit <= 30)
                    {
                        point += int.Parse(e.KeyChar.ToString());
                        s.PositionX = 0;
                        s.PictureMove(s.PositionX, s.PositionY);
                    }
                }
                if (e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' && timezone == true)
                {
                    hit = m.PositionX + pictureBox7.Size.Width - hook_m;
                    if (hit >= 0 && hit <= 30)
                    {
                        point += int.Parse(e.KeyChar.ToString());
                        m.PositionX = 0;
                        m.PictureMove(m.PositionX, m.PositionY);
                    }
                }
                hit = a.PositionX + pictureBox4.Size.Width - hook_a;
                if (hit >= 0 && hit <= 30)
                {
                    point += int.Parse(e.KeyChar.ToString());
                    a.PositionX = 0;
                    a.PictureMove(a.PositionX, a.PositionY);
                }
                label2.Text = "得点：" + point;
            }
        }
    }
}
