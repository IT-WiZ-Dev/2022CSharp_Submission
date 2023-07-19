using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    internal class ankou : Fish
    {
        public ankou(int posX, int posY, int speed, int formwidth, System.Windows.Forms.PictureBox picture)
            : base(posX, posY, speed, formwidth, picture)
        {

        }
    }
}
