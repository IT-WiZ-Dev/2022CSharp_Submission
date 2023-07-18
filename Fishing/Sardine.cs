using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Sardine : Fish
    {
        public Sardine(int positionX, int positionY, int speed,
             System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, picture)
        {
        

        }
    }
}
