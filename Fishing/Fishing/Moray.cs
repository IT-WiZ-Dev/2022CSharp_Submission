using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Moray:Fish
    {
        //ウツボ
        private int saveSpeed;
        private bool sleeping;
        private const int BaitMin = 7;
        public Moray(int posX, int poxY, int speed, int width, 
            System.Windows.Forms.PictureBox picture) : base(posX, poxY, speed, width, picture)
        {
            saveSpeed = speed;
            sleeping = false;
        }

        public void Getup()
        {
            Speed = saveSpeed;
            sleeping = false;
        }

        public void Sleep()
        {
            Speed = 0;
            sleeping = true;
        }

        public override int Eat(int p, System.Windows.Forms.PictureBox bait)
        {
            if(sleeping == false)
            {
                if (p >= BaitMin)
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
