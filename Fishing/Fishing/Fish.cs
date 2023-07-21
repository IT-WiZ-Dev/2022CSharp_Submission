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

        public PictureBox Pb {get;set;}
        
        //コンストラクタ
        
        public Fish(int posX,int posY,int speed,PictureBox pb)
        {
            PosX = posX;
            PosY = posY;
            Speed = speed;
            Pb = pb;
            IsFished = false;
        }
        //泳ぐメッソド

        public void Swin()
        {
            int x = Pb.Location.X;
            x += Speed;
        }
    }
}
