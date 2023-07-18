using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Muraenidae : Fish
    {
        public Muraenidae(int positionX, int positionY, int speed,
            System.Windows.Forms.PictureBox picture)
           : base(positionX, positionY, speed, picture)
        {
        }
    }
}
