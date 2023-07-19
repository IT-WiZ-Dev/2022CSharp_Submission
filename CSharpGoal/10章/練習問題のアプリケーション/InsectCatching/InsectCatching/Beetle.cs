using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCatching
{
    // カブトムシクラス
    class Beetle : Insect
    {
        // フィールド
        private int increment, incrementX, incrementY;  //増分値
        private const int IncrementMin = 10;            // 増分値の最小値
        private const int IncrementMax = 30;            // 増分値の最大値
        private Random random;

        // コンストラクター
        public Beetle(int moveWidth, int moveHeight, Random random)
            : base(0, 0, moveWidth, moveHeight, Properties.Resources.beetle_up)
        {
            this.random = random;

            //増分値を決める
            increment = this.random.Next(IncrementMin, IncrementMax);
            incrementX = 0;
            incrementY = -increment;
        }

        // 逃げる
        public override void RunAway()
        {
            // ピクチャーボックスの位置を取得し、増分値分更新する
            int x = Location.X;
            int y = Location.Y;
            x += incrementX;
            y += incrementY;

            // y座標が上の境界以上なら
            if (y < 0)
            {
                // 左向きに向きを変える
                incrementX = -increment;
                incrementY = 0;
                Image = Properties.Resources.beetle_upsidedown;
                x = MoveWidth - Size.Width;
                y = 0;
            }
            // x座標が左の境界以下なら
            else if (x < 0)
            {
                // 真下に向きを変える
                incrementX = 0;
                incrementY = increment;
                Image = Properties.Resources.beetle_down;
                x = 0;
                y = 0;
            }
            // y座標が下の境界以下なら
            else if (y > base.MoveHeight - base.Size.Height)
            {
                // 右向きに向きを変える
                incrementX = increment;
                incrementY = 0;
                Image = Properties.Resources.beetle_right;
                x = 0;
                y = MoveHeight - Size.Height;
            }
            // x座標が右の境界以上なら
            else if (x > MoveWidth - Size.Width)
            {
                // 真上に向きを変える
                incrementX = 0;
                incrementY = -increment;
                Image = Properties.Resources.beetle_up;
                x = MoveWidth - Size.Width;
                y = MoveHeight - Size.Height;
            }

            // ピクチャーボックスの位置を更新する
            Location = new Point(x, y);
        }

        // 位置、増分値、画像をリセットする
        public override void Reset()
        {
            Location = new Point(MoveWidth - Size.Width,
                                    MoveHeight - Size.Height);
            increment = random.Next(IncrementMin, IncrementMax);
            incrementX = 0;
            incrementY = -increment;
            Image = Properties.Resources.beetle_up;
        }
    }
}
