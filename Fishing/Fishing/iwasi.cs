using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    internal class iwasi : Fish
    {

        private bool sleeping = false;
        private const int esaMax = 3;


        public iwasi(int posX, int posY, int speed,int formwidth, System.Windows.Forms.PictureBox picture)
            : base(posX, posY, speed, formwidth, picture)
        {

        }

        public override int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            // 起きている時のみ食べる
            if (sleeping == false)
            {
                // 小さな餌しか食べない
                if (point <= esaMax)
                    point = base.Eat(point, esa);
                else
                    point = 0;
            }
            else
                point = 0;

            return point;
        }

        public void Sleep()
        {
            sleeping = true;
        }

        public void WakeUp()
        {
            sleeping = false;
        }

    }

}
