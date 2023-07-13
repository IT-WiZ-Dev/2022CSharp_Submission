using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai8syouR
{
     class iwasi : sakana
    {
        private int speed;
        private bool sleep;
        public iwasi(int positionX, int positionY, int speed,
                      int move, PictureBox picture) : base(positionX, positionY, speed, move, picture)

        {
            this.speed = speed;
            sleep = false;
        }
        public void Sleep()
        {
            sleep = true;
        }
        public void WakeUp()
        {
            sleep = false;
        }
        public new int tabelu(int suzi, PictureBox esa)
        {
            if (sleep ==false)
                 {
                if (suzi <= 3)
                {//3以下しか食べない
                    suzi = base.tabelu(suzi, esa);
                }
                else
                {
                    suzi = 0;
                }
            }

            return suzi;
        }
    }
}
