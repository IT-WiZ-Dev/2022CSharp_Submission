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
        private System.Windows.Forms.PictureBox picture;

        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Speed { get; set; }
        public int Movef { get; set; }

        //コンストラクタ   
        public Fish(int posX, int posY, int speed, int movef, System.Windows.Forms.PictureBox picture)
        {
            PosX = posX;
            PosY = posY;
            Speed = speed;
            Movef = movef;
            this.picture = picture;
        }

        //泳ぐメソッド
        public void Swim(out int x, out int y)
        {
            PosX = PosX + Speed;

            if (PosX > Movef)
                PosX = -picture.Size.Width;

            x = PosX;
            y = PosY;
        }

        public int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            int a = (picture.Location.X + picture.Size.Width) - (esa.Location.X + esa.Size.Width);
            if (a >= 0 && a <= 30)
            {
                PosX = -picture.Size.Width * 2;
                Move(PosX, PosY);
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

