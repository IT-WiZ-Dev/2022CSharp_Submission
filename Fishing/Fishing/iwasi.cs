using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class iwasi:sakana
    {
        public iwasi(int positionX, int positionY, int speed,
            int distanceX, bool tabeta, int time,  PictureBox picture)
            : base(positionX, positionY, speed, distanceX, tabeta, time,  picture)
        {
            
        }
    }
}
