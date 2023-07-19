using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    //イワシクラス
    class Iwashi:Fish
    {
        private bool sleep = false;　　//寝ているかどうか

        public Iwashi(int posX, int posY, int speed, System.Windows.Forms.PictureBox pb, int moveWidth)
            :base(posX,posY,speed,pb,moveWidth)
        {
        }

        public void SleepDown()
        {
            sleep = true;
        }

        public void SleepUp()
        {
            sleep = false;
        }

        public override int Get(int score, PictureBox esa)
        {
            if (sleep == false && score <= 3)
            {
                score = base.Get(score, esa); ;
            }
            else
                score = 0;

            return score; 
        }
    }
}
