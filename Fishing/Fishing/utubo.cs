using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class utubo:sakana
    {
        public utubo(int positionX, int positionY, int speed,
            int distanceX, bool tabeta, int time,PictureBox picture)
            : base(positionX, positionY, speed, distanceX, tabeta, time,picture)
        {
            
        }
        public int YoruU()
        {
            Speed = 0;
            return Speed;
        }
    }
}
