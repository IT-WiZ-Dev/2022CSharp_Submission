using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue
{
    // ヘリコプタークラス
    class Helicopter : Vehicle
    {
        // コンストラクター
        public Helicopter(int positionX, int positionY, int speed,
            int distanceX, System.Windows.Forms.PictureBox picture,
            int maxHigh, int minHigh)
            : base(positionX, positionY, speed, distanceX, picture)
        {
            MaxHigh = maxHigh;
            MinHigh = minHigh;
        }

        // プロパティ
        public int MaxHigh { get; private set; }    // 最高高度
        public int MinHigh { get; private set; }    // 最低高度

        // 飛ぶ
        //（仮引数）x：更新座標x　y：更新座標y
        //（戻り値）true：前進可能　false：到着
        public override bool Run(out int x, out int y)
        {
            bool rc = true;

            // 現在位置をスピード分進める
            PositionX += Speed;

            // 目的地に着いたら
            if (PositionX >= DistanceX)
            {
                PositionX = DistanceX;      // もう進めない
                PositionY += Speed / 2;     // 高度を下げる
                if (PositionY >= MinHigh)
                {
                    PositionY = MinHigh;    // 最低高度を下回らない
                    rc = false;
                }
            }
            // 目的地に着いていない
            else
            {
                PositionY -= Speed / 2;     // 高度を上げる
                if (PositionY <= MaxHigh)
                    PositionY = MaxHigh;    // 最高高度を超えない
            }

            x = PositionX;
            y = PositionY;

            return rc;
        }

        // 嵐が来た
        public void Storm()
        {
            // 目的地を現在地にして途中で飛行を中止する
            DistanceX = PositionX;
        }
    }
}
