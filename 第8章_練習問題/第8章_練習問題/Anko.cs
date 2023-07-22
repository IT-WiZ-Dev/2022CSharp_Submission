using Fishing;
using System;

namespace 第8章_練習問題
{
    class Anko : Fish
    {
        //public const int EsaMax = 3;

        //コンストラクタ
        public Anko(int positionX, int positionY, int speed,
            int moveWidth, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        { }
    }
}
