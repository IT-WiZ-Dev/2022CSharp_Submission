using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Ankou : Fish
    {
        public Ankou(int positionX, int positionY, int speed,int distancex, System.Windows.Forms.PictureBox pb)
            : base(positionX, positionY, speed,distancex, pb)
        {

        }
        
    }
}
