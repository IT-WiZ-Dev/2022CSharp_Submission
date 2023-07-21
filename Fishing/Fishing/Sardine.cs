using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Sardine:Fish
    {
        //イワシ
        private bool sleeping;
        private const int BaitMax = 3;
        public Sardine(int posX, int poxY, int speed, int width,
            System.Windows.Forms.PictureBox picture):base (posX, poxY, speed, width, picture)
        {
            sleeping = false;
        }
        
        public void Sleep()
        {
            sleeping = true;
        }

        public void Getup()
        {
            sleeping = false;
        }

        public override int Eat(int p, System.Windows.Forms.PictureBox bait)
        {
            if(sleeping == false)
            {
                if (p <= BaitMax)
                    p = base.Eat(p, bait);
                else
                    p = 0;
            }
            else
                p = 0;

            return p;
        }

    }
}
