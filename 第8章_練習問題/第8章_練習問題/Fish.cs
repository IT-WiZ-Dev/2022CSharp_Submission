using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    // 魚クラス
    class Fish
    {
        //フィールド
        private System.Windows.Forms.PictureBox picture;//表示

        private const int OverlapMin = 0;//ごはんとの重なり
        private const int OverlapMax = 30;

        //コンストラクタ


        public Fish(int positionX, int positionY, int speed, int moveWidth, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            MoveWidth = moveWidth;
            this.picture = picture;
        }

        //プロパティ
        public int PositionX { get; set; }//位置x
        public int PositionY { get; set; }//位置y
        public int Speed { get; set; }//スピード
        //public bool IsFished { get; set; }//目的地==つられたとき
        //public  PictureBox Pb { get; set; }//スピード
        public int MoveWidth { get; private set; }

        //泳ぐ
        //（仮引数）x:更新座標x　ｙ：更新座標ｙ
        //（戻り値）true:前進可能　false:到着
        public void Run(out int x, out int y)
        {
            PositionX += Speed;

            //移動範囲を超えたら回遊させる
            if (PositionX > MoveWidth)
                PositionX = -picture.Size.Width;

            x = PositionX;
            y = PositionY;

        }

        public virtual int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            int overlap = (picture.Location.X + picture.Size.Width)
                - (esa.Location.X + esa.Size.Width);

            if (overlap >= OverlapMin && overlap <= OverlapMax)
            //overlapが0以上であり、overlapが30以下
            {
                //食ったら見えなくなる
                PositionX = -picture.Size.Width * 2;
                PictureMove(PositionX, PositionY);
            }
            else
                //食ってない
                point = 0;

            return point;
        }

        //ピクチャーボックスを移動する
        //（仮引数）x:移動先座標x　y：移動先座標y
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}

