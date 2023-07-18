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
             System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            isFish = false;
            this.picture = picture;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }

        public bool isFish { get; set; }

        public const int RightEgde = 1027;

        public void Run(out int x, out int y) 
        {
            PositionX += Speed;
            
            if (PositionX > RightEgde)//右端に着いたら左端に移動する
            {
                PositionX = 0 - picture.Width;
            }

            x = PositionX;
            y = PositionY; 


        }

        
        public void PictureMove(int x, int y, bool isFish)
        {
            if (isFish == true)
            {
                PositionX = 0 - picture.Width;

            }
            picture.Location = new System.Drawing.Point(x, y);//移動させる処理
        }
    }
}
