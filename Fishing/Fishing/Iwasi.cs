using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Iwasi:Sakana
    {
        // フィールド
        private bool sleeping;          // 睡眠中はtrue
        private const int EsaMax = 3;   // 食べる餌の最大サイズ

        // コンストラクター
        public Iwasi(int positionX, int positionY, int speed, int moveWidth,
            System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            sleeping = false;
        }

        // 寝る
        public void Sleep()
        {
            sleeping = true;
        }

        // 起きる
        public void WakeUp()
        {
            sleeping = false;
        }

        // 餌を食べる
        //（仮引数）point：餌のポイント esa：餌のピクチャボックス
        //（返却値）ポイント
        public override int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            // 起きている時のみ食べる
            if (sleeping == false)
            {
                // 小さな餌しか食べない
                if (point <= EsaMax)
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
