using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    
    class Iwa : Fish
    {
        private bool sleeping;  

        public Iwa(int positionX, int positionY, int speed, int moveWidth, 
            System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            sleeping = false;
        }

        
        public void Sleep()
        {
            sleeping = true;
        }

       
        public void WakeUp()
        {
            sleeping = false;
        }

       
        public new int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
          
            if (sleeping == false)
            {
               
                if (point <= 3)
                    point = base.Eat(point, esa);
                else
                    point = 0;
            }
            else
                point = 0;

            return point;
        }
    }
}
