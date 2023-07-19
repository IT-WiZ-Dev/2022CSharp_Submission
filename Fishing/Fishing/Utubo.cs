using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class Utubo : Fish
    {
        private int key = 7; //最小キー
        private bool sleep = false; //睡眠状態

        public Utubo(int posX, int posY, int speed, System.Windows.Forms.PictureBox pb,int moveWidth)
            : base(posX, posY, speed, pb,moveWidth)
        {

        }
        public void SleepDown()
        {
            sleep = true;
            Speed = 0;
        }

        public void SleepUp()
        {
            sleep = false;
            Speed = 10;
        }

        public override int Get(int score, PictureBox esa)
        {
            if (sleep == false || score >= 7)
            {
                score = base.Get(score, esa);
            }
            else
                score = 0;

            return score;
        }
    }
}
