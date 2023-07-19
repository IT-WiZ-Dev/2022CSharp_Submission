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

        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Speed { get; set; }
        public bool IsFished { get; set; }
        public PictureBox Pb { get; set; }
        public int MoveWidth { get; private set; }

        //コンストラクタ
        public Fish(int posX, int posY, int speed, PictureBox pb, int moveWidth)
        {
            PosX = posX;
            PosY = posY;
            Speed = speed;
            Pb = pb;
            MoveWidth = moveWidth;
            IsFished = false;
        }

        //泳ぐメソッド
        public void Swim(out int x, out int y)
        {
            PosX += Speed;

            if (PosX > MoveWidth) //回遊
                PosX = -Pb.Size.Width;

            x = PosX;
            y = PosY;
        }

        public virtual int Get(int score,PictureBox esa)
        {

            int getArea = Pb.Location.X - esa.Location.X ;
            if (getArea >= 0 && getArea <= 30)
            {
                PosX = -Pb.Size.Width * 2;
                PbMove(PosX, PosY);
            }
            else
                score = 0;

            return score;
        }
        public void PbMove(int x, int y)
        {
            Pb.Location = new System.Drawing.Point(x, y);
        }
    
    }
}
