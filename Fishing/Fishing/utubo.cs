using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{


    internal class utubo : Fish
    {

        private const int esaMin = 7;
        private bool sleeping=false;


        public utubo(int posX, int posY, int speed, int formwidth, System.Windows.Forms.PictureBox picture)
            : base(posX, posY, speed, formwidth, picture)
        {

        }

        public void Sleep()
        {
            Speed = 0;
        }

        public void WakeUp()
        {
            Speed = 10;
        }


        public override int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            // 起きている時のみ食べる
            if (sleeping == false)
            {
                // 大きな餌しか食べない
                if (point >= esaMin)
                    point = base.Eat(point, esa);
                else
                    point = 0;
            }
            else
                point = 0;

            return point;
        }

    }
}
