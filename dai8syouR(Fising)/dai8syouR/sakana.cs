using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai8syouR
{
     class sakana
    {
        
        public sakana(int positionX, int positionY, int speed,
            int move, PictureBox picture)
           
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            IsFish = false;
            Picture = picture;
            Movehani = move;

        }
        public int PositionX { get; set; }//itiX
        public int PositionY
        {
            get; set;
        }
        public int Speed { get; set; }//スピード
        public bool IsFish { get; set; }
        public PictureBox Picture { get; set; }

        public int Movehani { get; private set; }
        public void Swim(out int x,out int y) //泳ぐめそっと
        {
            PositionX += Speed;
            if (PositionX > Movehani)
             PositionX=-Picture.Size.Width;
            x = PositionX;
            y = PositionY;
        }
        public int tabelu(int suzi, PictureBox esa)
        {
           
            int over = (Picture.Location.X + Picture.Size.Width) -
                (esa.Location.X + esa.Size.Width);
            if (over >= 0 && over <= 30)
            {
              
                PositionX = -Picture.Size.Width * 2; ;
                move(PositionX, PositionY);
              
            }
            else
            {
                suzi = 0;
            }
               
                

            return suzi;
        }

        public void move(int x, int y)
        {
            Picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
