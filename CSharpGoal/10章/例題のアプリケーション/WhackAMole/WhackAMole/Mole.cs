using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackAMole
{
    // モグラクラス
    class Mole : JumpAnimal
    {
        // フィールド
        private bool upDown;    // true：上がる　false：下がる

        // コンストラクター
        public Mole(int holeX, int holeY, int speed)
        : base(holeX, holeY, speed, Properties.Resources.mole)
        {
            upDown = true;
        }

        // 飛び出す
        public override void Jump()
        {
            Jumping = true; // ジャンプ中

            int x = Location.X;
            int y = Location.Y;

            if (upDown == true)
            {
                // 上がる
                y -= Speed;     // 左上が原点なので減算
                if (y < HoleY - Size.Height * 2 / 3)
                {
                    // 身体を2/3だけ穴から出す
                    y = HoleY - Size.Height * 2 / 3;
                    upDown = false;
                }
            }
            else
            {
                // 下がる
                y += Speed;     // 左上が原点なので加算
                if (y > HoleY)
                {
                    // 穴の位置で止まりジャンプ中を解除
                    y = HoleY;
                    upDown = true;
                    Jumping = false;
                }
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
            Score += 1;
            return Score;
        }
    }
}
