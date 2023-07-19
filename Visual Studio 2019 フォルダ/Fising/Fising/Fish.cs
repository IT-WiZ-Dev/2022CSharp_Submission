using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fising
{
    class Fish
    {
        private System.Windows.Forms.PictureBox picture;
        private const int OverlapMin = 0;
        private const int OverlapMax = 30;

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

        public virtual int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
              int overlap = (picture.Location.X + picture.Size.Width) -
                (esa.Location.X + esa.Size.Width);
            if (overlap >= OverlapMin && overlap <= OverlapMax)
            {
                PositionX = -picture.Size.Width * 2;
                PictureMove(PositionX, PositionY);
            }
            else

                point = 0;

            return point;
        }

        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
