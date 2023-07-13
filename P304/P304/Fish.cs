using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P304
{
    class Fish
    {
        private System.Windows.Forms.PictureBox picture;
        public Fish(int positionX, int positionY, int speed,int distanceX, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            this.picture = picture;
            Seelp = false;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int DistanceX { get; private set; }


        public bool Seelp { get; set; }

        public void Run(out int x, out int y)
        {
            PositionX += Speed;

            if (PositionX >= DistanceX)
            {
                pointXBack();
            }

            x = PositionX;
            y = PositionY;
        }

        public void PrictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }


        public bool checkEat(System.Windows.Forms.PictureBox esa)
        {
            int p = (picture.Location.X + picture.Size.Width) - (esa.Location.X + esa.Size.Width);

            if (p >= 0 && p <= 30)
            {
                pointXBack();
                return true;
            }
            return false;
        }
        internal void pointXBack()
        {
            PositionX = -100;
            PrictureMove(PositionX, PositionY);
        }
    }
}
