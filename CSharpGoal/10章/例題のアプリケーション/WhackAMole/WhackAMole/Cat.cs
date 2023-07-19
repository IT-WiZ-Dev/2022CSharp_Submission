using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WhackAMole
{
    // 猫クラス
    class Cat : JumpAnimal
    {
        // フィールド
        private double angle;   // 回転中の猫の角度
        private int cx, cy;     // 円の中心座標
        private int r;          // 半径の長さ

        // コンストラクター
        public Cat(int holeX, int holeY, int speed)
        : base(holeX, holeY, speed, Properties.Resources.cat)
        {
            angle = -90.0;  // 角度-90度
            cx = HoleX + Size.Width / 2;
            cy = HoleY - Size.Height;
            r = Size.Height;
        }

        // 飛び出す
        public override void Jump()
        {
            Jumping = true; // ジャンプ中

            // 円周上の座標
            int x = (int)(cx + r * Math.Cos(angle * Math.PI / 180.0));
            int y = (int)(cy - r * Math.Sin(angle * Math.PI / 180.0));

            // PictureBoxの位置を更新する
            Location = new Point(x - Size.Width / 2, y);
            angle += 15.0;

            if (angle >= 270.0)
            {
                //穴の位置に戻り、ジャンプ中を解除
                angle = -90.0;
                Location = new Point(HoleX, HoleY);
                Jumping = false;
            }
        }

        // 当たった
        //（返却値）更新した得点
        public override int Hit()
        {
            // 角度を戻す
            angle = -90.0;
            // 位置を戻し、ジャンプ中解除
            Location = new Point(HoleX, HoleY);
            Jumping = false;

            // 加点する
            Score += 3;
            return Score;
        }
    }
}
