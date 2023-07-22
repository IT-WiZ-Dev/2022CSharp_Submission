using Fishing;
using System;

namespace 第8章_練習問題
{
    class Iwashi : Fish
    {
        //フィールド
        public bool sleeping;
        public const int EsaMax = 3;

        //コンストラクタ
        public Iwashi(int positionX, int positionY, int speed,
            int moveWidth, System.Windows.Forms.PictureBox picture)
            :base (positionX, positionY, speed, moveWidth, picture)
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


        //泳ぐ
        //（仮引数）x:更新座標ｘ　ｙ：更新座標ｙ
        //（戻り値）true:前進可能　false:到着
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
