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
        private const int OverlapMin = 0;
        private const int OverlapMax = 30;

        public Fish(int posX, int posY, int speed,
            int formwidth, System.Windows.Forms.PictureBox picture)
        {
            PosX = posX;
            PosY = posY;
            Speed = speed;
            this.picture = picture;
            DisX = formwidth;

        }


        public int PosX {  get; set; }
        public int PosY { get; set; }
        public int Speed { get; set;  }
        public int DisX { get; private set; }  //目的地



        public void Run(out int x, out int y)
        {

            //x = PosX;
            PosX += Speed;

            if (PosX > DisX)
            {
                PosX = -picture.Size.Width;
            }

            x = PosX;
            y = PosY;

        }

        public virtual int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            // 餌と魚が重なると餌を食べる
            int overlap = (picture.Location.X + picture.Size.Width) -
                (esa.Location.X + esa.Size.Width);
            if (overlap >= OverlapMin && overlap <= OverlapMax)
            {
                // 餌を食べたので見えなくする
                PosX = -picture.Size.Width * 2;
                PictureMove(PosX, PosY);
            }
            else
                // 餌を食べない
                point = 0;

            return point;
        }
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
