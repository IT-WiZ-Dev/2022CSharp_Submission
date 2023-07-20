using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第8章練習問題_Fishing_
{
    class Fish
    {
        private System.Windows.Forms.PictureBox picture;
        private const int hanteiMin = 0;  //魚とエサが重なってから30px以内に数字キーを押すと餌を食べる判定
        private const int hanteiMax = 30;


        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Speed { get; set; }
       /* public PictureBox Pb { get; set; } */
        /*public bool IsFished { get; set; } */
        public int IdouHaba { get; private set; }



        //コンストラクタ
        public Fish(int posX, int posY, int speed ,int idouHaba,  PictureBox pb)
        {
            PosX = posX;
            PosY = posY;
            Speed = speed;
            this.picture = pb;
            IdouHaba = idouHaba;
           /*  IsFished = false; */

            
        }

        

        //泳ぐメソッド
        public void Swim(out int x, out int y)
        {
            PosX += Speed;

            if (PosX > IdouHaba)
                PosX = -picture.Size.Width;

            x = PosX;

            y = PosY;
        }

        //餌を食べるメソッド
        public virtual int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            int overlap = (picture.Location.X + picture.Size.Width) - (esa.Location.X + esa.Size.Width);

            if (overlap >= hanteiMin && overlap <= hanteiMax)
            {
                //餌を食べたら見えなくする
                PosX = -picture.Size.Width * 2;
                PictureMove(PosX, PosY);
            }
            else
                point = 0;
            return point;
        }
        //ピクチャーボックス移動のメゾッド
        public void PictureMove (int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }

}
