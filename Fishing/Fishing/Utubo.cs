using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Utubo : Fish
    {
        private int saveSpeed;
        private bool sleep;
        private const int EsaMin = 7;

        public Utubo(int positionX, int positionY, int speed, int moveWidth,
        System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            saveSpeed = speed;
            sleep = false;
        }
        
        public void Sleep()
        {
            Speed = 0;
            sleep = true;
        }

        public void WakeUp()
        {
            Speed = saveSpeed;
            sleep = false;
        }

        public override int Esa(int point, System.Windows.Forms.PictureBox esa)
        {
            if (sleep == false)
            {
                if (point >= EsaMin)
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
