using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fish
    {
        //フィールド
        private System.Windows.Forms.PictureBox picture;
       
        //コンストラクタ
        public Fish(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            this.picture = picture;
        }

        //プロパティ
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int DistanceX { get; set; }
      
        //泳ぐ
        public void Swim(out int x,out int y)
        {
            PositionX += Speed;

            if (PositionX > DistanceX)
            {
                PositionX = -picture.Size.Width;
            }
            x = PositionX;
            y = PositionY;
        }

        //餌を食べる
        public virtual int EatFeed(int number, System.Windows.Forms.PictureBox feed)
        {
            int difference = (picture.Location.X + picture.Size.Width) - (feed.Location.X + feed.Size.Width);

            if(difference >= 0 && difference <= 30)
            {
                PositionX = -picture.Size.Width * 2;
                PictureMove(PositionX, PositionY);
            }
            else
            {
                number = 0;
            }
            return number;
        }

        //ピクチャーボックスを移動する
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
