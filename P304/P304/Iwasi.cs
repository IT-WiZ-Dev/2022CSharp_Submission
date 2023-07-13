using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P304
{
    class Iwasi : Fish
    {
        public Iwasi(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
        : base(positionX, positionY, speed, distanceX, picture)
        {

        }
        public int Eat(int num, PictureBox pictureBox)
        {
            //MessageBox.Show(num.ToString());
            if (Seelp)
            {
                return 0;
            }
            if (num <= 3)
            {
                if (base.checkEat(pictureBox))
                {
                    return 10;
                }
            }
            return 0;
        }
        public void sleep()
        {
            Seelp = true;
        }
        public void okiru()
        {
            Seelp = false;
        }

    }
}
