using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fishing
{
    class Utubo : Sakana
    {
        public Utubo(int positionX, int positionY, int speed, int distanceX,int time, PictureBox pb)
            : base(positionX, positionY, speed, distanceX,time, pb)
        {

        }

        public int teisi()
        {
            Speed = 0;
            return Speed;
        }

        public int saikai()
        {
            Speed = 10;
            return Speed;
        }
    }
}
