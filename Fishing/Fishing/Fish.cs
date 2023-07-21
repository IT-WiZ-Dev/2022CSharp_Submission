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
        private const int OLapMin = 0;               
        private const int OLapMax = 30;              


        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Speed { get; set; }
        public bool IsFished { get; set; }

        public PictureBox Pb { get; set; }

        public int Width { get; private set; }


        public Fish(int posX, int poxY, int speed, int width, System.Windows.Forms.PictureBox picture)
        {
            PosX = posX;
            PosY = poxY;
            Speed = speed;
            Width = width;
            IsFished = false;
            Pb = picture;

        }
        //進む
        //仮引数　x:更新座標x y:更新座標y
        //戻り値　ture 前進可能 false 到着
        public virtual bool Swing(out int x, out int y)
        {
            IsFished = true;
            //現在位置をスピード分進める
            PosX += Speed;
            //端に行ったら回遊させる
            if (PosX >= Width)
            {
                PosX = -Pb.Size.Width;
                IsFished = false;

            }
            x = PosX;
            y = PosY;
            return IsFished;
        }

        public virtual int Eat(int p,System.Windows.Forms.PictureBox bait)
        {
            int oLap = (Pb.Location.X + Pb.Size.Width) -
                (bait.Location.X + bait.Size.Width);
            if (oLap >= OLapMin && oLap <= OLapMax)
            {
                // 餌を食べたので見えなくする
                PosX = -Pb.Size.Width * 2;
                PbMove(PosX, PosY);
            }
            else
                // 餌を食べない
                p = 0;

            return p;
        }

        public void PbMove(int x, int y)
        {
            Pb.Location = new System.Drawing.Point(x, y);
        }
    }
}