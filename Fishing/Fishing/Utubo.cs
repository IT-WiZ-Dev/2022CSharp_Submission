using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Utubo : Fish
    {
        private int speed;      // スピードの保存用変数
        private bool sleeping;  // 睡眠中はtrue

        public Utubo(int positionX, int positionY, int speed, int moveWidth,
            System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            this.speed = speed;
            sleeping = false;
        }

        // 寝る
        public void Sleep()
        {
            // 睡眠中は泳がない
            base.Speed = 0;
            sleeping = true;
        }

        // 起きる
        public void WakeUp()
        {
            // 起きたら泳ぐ
            base.Speed = this.speed;
            sleeping = false;
        }

        // 餌を食べる
        //（仮引数）point：餌のポイント esa：餌のピクチャボックス
        //（返却値）ポイント
        public new int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            // 起きている時のみ食べる
            if (sleeping == false)
            {
                // 大きな餌しか食べない
                if (point >= 7)
                    point = base.Eat(point, esa);
                else
                    point = 0;
            }
            else
                point = 0;

            return point;
        }
    }
}
