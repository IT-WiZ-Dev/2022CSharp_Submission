using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class Fish
    {
        private PictureBox picture;

        public Fish(int positionX,int positionY,int speed,int distanceX,
            System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            IsSwim = true;
            this.picture = picture;
        }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int DistanceX { get; set; }
        public bool IsSwim{ get; set; }
        public PictureBox Pb { get; set; }

        public void PictureMove(int x,int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

        public virtual bool swim()
        {
            bool rc = true;

            PositionX += Speed;
            if (!IsSwim)
            {
                return false;
            }

            if (PositionX > DistanceX +300)
            {
                PositionX = -300;
            }

            Swim();
            return rc;

        }

        public void Swimming(int x,int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

        public void Swim()
        {
            picture.Location = new System.Drawing.Point(PositionX, PositionY);
        }
    }
}
