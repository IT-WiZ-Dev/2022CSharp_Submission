using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P304
{
    class Ankou : Fish
    {
        public Ankou(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
　　　　: base(positionX, positionY, speed, distanceX, picture)
        {

        }
        public int Eat(PictureBox pictureBox)
        {
            if (base.checkEat(pictureBox))
            {
                return 5;
            }
            return 0;
        }
    }
}
