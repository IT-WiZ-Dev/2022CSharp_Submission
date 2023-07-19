using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCatching
{
    // トンボクラス
    class Dragonfly : Insect
    {
        // フィールド
        private int incrementX, incrementY;         // 増分値
        private const int IncrementMin = 10;        // 増分値の最小値
        private const int IncrementMax = 30;        // 増分値の最大値
        private Random random;

        // コンストラクター
        public Dragonfly(int moveWidth, int moveHeight, Random random)
            : base(0, 0, moveWidth, moveHeight, Properties.Resources.dragonfly_right)
        {
            this.random = random;

            // 増分値を決める
            incrementX = this.random.Next(IncrementMin, IncrementMax);
            incrementY = this.random.Next(IncrementMin, IncrementMax);
        }

        // 逃げる
        public override void RunAway()
        {
            // ピクチャーボックスの位置を取得し、増分値分更新する
            int x = Location.X;
            int y = Location.Y;
            x += incrementX;
            y += incrementY;

            // x座標が左の境界以下なら
            if (x < 0)
            {
                // 右方向に向きを変える
                incrementX *= -1;
                x = 0;
                Image = Properties.Resources.dragonfly_right;
            }
            // x座標が右の境界以上なら
            else if (x > MoveWidth - Size.Width)
            {
                // 左方向に向きを変える
                incrementX *= -1;
                x = MoveWidth - Size.Width;
                Image = Properties.Resources.dragonfly_left;
            }

            // y座標が上の境界以上なら
            if (y < 0)
            {
                // 下方向に向きを変える
                incrementY *= -1;
                y = 0;
            }
            // y座標が下の境界以下なら
            else if (y > MoveHeight - Size.Height)
            {
                // 上方向に向きを変える
                incrementY *= -1;
                y = MoveHeight - Size.Height;
            }

            // ピクチャーボックスの位置を更新する
            Location = new Point(x, y);
        }

        // 位置、増分値、画像をリセットする
        public override void Reset()
        {
            Location = new Point(0, 0);
            incrementX = random.Next(IncrementMin, IncrementMax);
            incrementY = random.Next(IncrementMin, IncrementMax);
            Image = Properties.Resources.dragonfly_right;
        }
    }
}
