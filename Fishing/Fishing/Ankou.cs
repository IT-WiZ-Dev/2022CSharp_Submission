using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Ankou:Fish
    {
        public Ankou(int posX, int posY, int speed, System.Windows.Forms.PictureBox pb, int moveWidth)
            :base(posX,posY,speed,pb,moveWidth)
        {

        }
    }
}
