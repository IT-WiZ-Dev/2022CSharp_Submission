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
        //private System.Windows.Forms.PictureBox.picture;
        private const int OverlapMin = 0;
        private const int OverlapMax = 30;

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int MoveWidth { get; set; }
        public bool IsFished { get; set; }
        
        public PictureBox Pb { get; set; } // プロパティ大文字

        // コンストラクタ
        public Fish(int positionx,int positiony,int speed,int moveWidth,PictureBox pb)
        {
            PositionX = positionx;
            PositionY = positiony;
            Speed = speed;
            MoveWidth = moveWidth;
            Pb = pb;
            IsFished = false;

        }

        public void Swim(out int x,out int y)
        {
            x = Pb.Location.X;
            x += Speed;
            y = Pb.Location.Y;
            if(PositionX > MoveWidth)
            {
                PositionX = -Pb.Size.Width;
            }
            x = PositionX;
            y = PositionY;
        }

        public virtual int Esa(int point,PictureBox esa)
        {
            int overlap = (Pb.Location.X + Pb.Size.Width) - (esa.Location.X + esa.Size.Width);
            if(overlap >= OverlapMin && overlap <= OverlapMax)
            {
                PositionX = -Pb.Size.Width * 2;
                PictureMove(PositionX, PositionY);
            }
            else
            {
                point = 0;
            }
            return point;
        }

        public void PictureMove(int x,int y)
        {
            Pb.Location = new System.Drawing.Point(x,y);
        }
    }
}

