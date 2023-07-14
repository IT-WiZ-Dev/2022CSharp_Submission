using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fishing
{
    class Ankou : Sakana
    {
        public Ankou(int positionX, int positionY, int speed, int distanceX,int time, PictureBox pb)
            : base(positionX, positionY, speed, distanceX,time, pb)
        {

        }
    }
}
