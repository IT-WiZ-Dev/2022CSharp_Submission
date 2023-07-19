using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    // ウツボクラス
    class Utubo : Fish
    {
        // フィールド
        private int saveSpeed;          // スピードの保存用変数
        private bool sleeping;          // 睡眠中はtrue
        private const int EsaMin = 7;   // 食べる餌の最小サイズ

        // コンストラクター
        public Utubo(int positionX, int positionY, int speed, int moveWidth,
        System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            saveSpeed = speed;
            sleeping = false;
        }

        // 寝る
        public void Sleep()
        {
            // 睡眠中は泳がない
            Speed = 0;
            sleeping = true;
        }

        // 起きる
        public void WakeUp()
        {
            // 起きたら泳ぐ
            Speed = saveSpeed;
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
                // 大きな餌しか食べない
                if (point >= EsaMin)
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
