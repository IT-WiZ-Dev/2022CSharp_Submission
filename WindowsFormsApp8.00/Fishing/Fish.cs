using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    
    class Fish
    {
        
        private System.Windows.Forms.PictureBox picture;        

        
        public Fish(int positionX, int positionY, int speed, 
            int moveWidth, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            MoveWidth = moveWidth;
            this.picture = picture;
        }

        
        public int PositionX { get; set; }              
        public int PositionY { get; set; }              
        public int Speed { get; set; }                  
        public int MoveWidth { get; private set; }      

        
        public void Swim(out int x, out int y)
        {
            PositionX += Speed;

           
            if (PositionX > MoveWidth)
                PositionX = -picture.Size.Width;

            x = PositionX;
            y = PositionY;
        }

        
        public int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            
            int overlap = (picture.Location.X + picture.Size.Width) -
                (esa.Location.X + esa.Size.Width);
            if (overlap >= 0 && overlap <= 30)
            {
      
                PositionX = -picture.Size.Width * 2;
                Move(PositionX, PositionY);
            }
            else
               
                point = 0;

            return point;
        }

        public void Move(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
