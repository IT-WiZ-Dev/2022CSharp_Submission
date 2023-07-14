using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Fishing
{
    class Sakana
    {
        //フィールド
        private PictureBox picture;

        //コンストラクター
        public Sakana(int positionX, int positionY, int speed, int distanceX,int time, PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            this.picture = picture;
            Turu = false;
            Time = time;
            isSwim = true;
        }

        //プロパティ
        public int PositionX { get; set; }//位置x
        public int PositionY { get; set; }//位置y
        public int Speed { get; set; }    //スピード
        public int DistanceX { get; set; }
        public bool Turu { get; set; }//釣られたかの判定
        public int Time { get; set; }

        public bool isSwim { get; set; }

        public virtual bool Run()
        {
            bool rc = true;


            //現在位置をスピード分進める
            PositionX += Speed;

            if (!isSwim)
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

        //ピクチャーボックスを移動する
        //(仮引数)x：移動先座標x　y：移動先座標y
        public void Swim(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

        public void Swim()
        {
            picture.Location = new System.Drawing.Point(PositionX, PositionY);
        }
    }
}
