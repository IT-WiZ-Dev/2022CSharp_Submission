using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class Iwashi : Fish
    {
        private bool sleep;
        private const int EsaMax = 3;

        public Iwashi(int positionX,int PositionY,int speed,int moveWidth,PictureBox picture)
            : base(positionX, PositionY, speed, moveWidth, picture)
        {
            sleep = false;
        }

        public void Sleep()
        {
            sleep = true;
        }

        public void WakeUp()
        {
            sleep = false;
        }
        public override int Esa(int point,PictureBox esa)
        {
            if (sleep == false)
            {
                if(point <= EsaMax)
                {
                    point = base.Esa(point, esa);
                }
                else
                {
                    point = 0;
                }
            }
            else
            {
                point = 0;
            }
            return point;
        }
    }
}
