using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P304
{
    class Utubo : Fish
    {
        public Utubo(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
        : base(positionX, positionY, speed, distanceX, picture)
        {

        }
        public int Eat(int num, PictureBox pictureBox)
        {
            if (Seelp)
            {
                return 0;
            }
            if (num >= 7)
            {
                if (base.checkEat(pictureBox))
                {
                    return 20;
                }
            }
            return 0;
        }
        public void sleep()
        {
            Seelp = true;
            Speed = 0;
        }
        public void okiru()
        {
            Seelp = false;
            Speed = 10;
        }
    }
}
