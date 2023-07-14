using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class Iwasi : Sakana
    {
        public Iwasi(int positionX, int positionY, int speed, int distanceX,int time, PictureBox pb)
            : base(positionX, positionY, speed, distanceX,time, pb)
        {

        }
        public int iti()
        {
            PositionX = -300;
            return PositionX;
        }
    }
}
