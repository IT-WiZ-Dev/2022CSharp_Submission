using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackAMole
{
    // 鳥クラス
    class Bird : JumpAnimal
    {
        // コンストラクター
        public Bird(int holeX, int holeY, int speed)
            : base(holeX, holeY, speed, Properties.Resources.bird)
        {
        }

        // 飛び出す
        public override void Jump()
        {
            Jumping = true;     // ジャンプ中
            int x = Location.X;
            int y = Location.Y;

            // 飛び去る
            y -= Speed;     // 左上が原点なので減算
            if (y + Size.Height < 0)
            {
                y = HoleY;
                Jumping = false;
            }

            // PictureBoxの位置を更新する
            Location = new Point(x, y);
        }

        // 当たった
        //（返却値）更新した得点
        public override int Hit()
        {
            // 位置を戻し、ジャンプ中解除
            Location = new Point(HoleX, HoleY);
            Jumping = false;

            // 加点する
            Score += 4;
            return Score;
        }
    }
}
