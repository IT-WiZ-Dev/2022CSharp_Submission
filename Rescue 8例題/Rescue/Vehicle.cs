using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue
{
    //乗り物クラス
    class Vehicle
    {
        //フィールド
        private System.Windows.Forms.PictureBox picture;

        //コンストラクター
        public Vehicle(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DistanceX = distanceX;
            this.picture = picture;
        }


        //プロパティ
        public int PositionX { get; set; } //位置x
        public int PositionY { get; set; } //位置y
        public int Speed { get; set; }     //スピード
        public int DistanceX { get; set; } //目的地x

        //進む
        //(仮引数)x:更新座標x y:更新座標y
        //(戻り値)true:前進可能 false:到着
        public virtual bool Run(out int x, out int y)
        {
            bool rc = true;

            //現在位置をスピード分進める
            PositionX += Speed;

            //目的地に着いたらもう進めない
            if(PositionX >= DistanceX)
            {
                PositionX = DistanceX;
                rc = false;
            }

            x = PositionX;
            y = PositionY;

            return rc;
        }

        //ピクチャーボックスを移動する
        //(仮引数)x:移動先座標x y:移動先座標y
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }

    }
}
