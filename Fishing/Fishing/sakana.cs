using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class sakana
    {
        private System.Windows.Forms.PictureBox picture;

        public sakana (int positionX, int positionY, int speed,
            int distanceX, bool tabeta,int time,PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            this.picture = picture;
            Tabeta = tabeta;
            Time = time;
            isSwim = true;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int DistanceX { get; set; }
        public bool Tabeta { get; set; }
        public int Time { get; set; }
        public bool isSwim { get; set; }
        public virtual bool Run()
        {
            bool rs = true;
            PositionX += Speed;
            if (!isSwim)
            {
                return false;
            }

            if(PositionX >= DistanceX + 300)
            {
                PositionX = -300;
            }

            Swim();
            return rs;
        }
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

        public void Swim()
        {
            picture.Location = new System.Drawing.Point(PositionX, PositionY);
        }
        
    }
}
