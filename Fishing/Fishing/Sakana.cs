using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Sakana
    {
        // フィールド
        private System.Windows.Forms.PictureBox picture;// 画像表示用
        private const int OverlapMin = 0;               // 餌と魚の重なり最小
        private const int OverlapMax = 30;              // 餌と魚の重なり最大

        // コンストラクター
        public Sakana(int positionX, int positionY, int speed,
            int moveWidth, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            MoveWidth = moveWidth;
            this.picture = picture;
        }

        // プロパティ
        public int PositionX { get; set; }              // 位置x
        public int PositionY { get; set; }              // 位置y
        public int Speed { get; set; }                  // 泳ぐスピード
        public int MoveWidth { get; private set; }      // 移動範囲幅

        // 泳ぐ
        //（仮引数）x：更新座標x　y：更新座標y
        public void Swim(out int x, out int y)
        {
            PositionX += Speed;

            // 移動範囲幅を超えたら回遊させる
            if (PositionX > MoveWidth)
                PositionX = -picture.Size.Width;

            x = PositionX;
            y = PositionY;
        }

        // 餌を食べる
        //（仮引数）point：餌のポイント esa：餌のピクチャボックス
        //（返却値）ポイント
        public virtual int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            // 餌と魚が重なると餌を食べる
            int overlap = (picture.Location.X + picture.Size.Width) -
                (esa.Location.X + esa.Size.Width);
            if (overlap >= OverlapMin && overlap <= OverlapMax)
            {
                // 餌を食べたので見えなくする
                PositionX = -picture.Size.Width * 2;
                PictureMove(PositionX, PositionY);
            }
            else
                // 餌を食べない
                point = 0;

            return point;
        }

        // ピクチャーボックスを移動する
        //（仮引数）x：移動位置x座標, y：移動位置y座標
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
