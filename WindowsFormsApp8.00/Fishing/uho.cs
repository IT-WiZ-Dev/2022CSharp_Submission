using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    
    class uho : Fish
    {
        private int speed;     
        private bool sleeping; 
        public uho(int positionX, int positionY, int speed, int moveWidth, 
            System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            this.speed = speed;
            sleeping = false;
        }

       
        public void Sleep()
        {
            
            base.Speed = 0;
            sleeping = true;
        }

        
        public void WakeUp()
        {
            
            base.Speed = this.speed;
            sleeping = false;
        }

        
        public new int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
           
            if (sleeping == false)
            {
               
                if (point >= 7)
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
