using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai8syouR
{
     class utubo : sakana
    {
        private int speed;
        private bool sleep;
        public utubo(int positionX, int positionY, int speed,
              int move, PictureBox picture):base(positionX,positionY,speed,move,picture)

        {
            this.speed = speed;
            sleep = false;
        }
        public void Sleep()
        {
            base.Speed = 0;
            sleep = true;
        }
        public void WakeUp()
        {
            base.Speed = 10; 
            sleep = false;
        }
        public new int tabelu(int suzi, PictureBox esa)
        {
            if (sleep == false)

            {
                if (suzi >= 7)//７以上しか食べれない
                    suzi = base.tabelu(suzi, esa);
                else
                    suzi = 0;
            }

            return suzi;
        }
    }
}
