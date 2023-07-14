using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    //ウツボクラス
    internal class MorayEel : Fish
    {
        // フィールド
        private int saveSpeed;
        private bool sleeping;
        private const int EsaMin = 7;

        // コンストラクター
        public MorayEel(int positionX, int positionY, int speed, int moveWidth,
        System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {
            saveSpeed = speed;
            sleeping = false;
        }


        public void Sleep()
        {

            Speed = 0;
            sleeping = true;
        }


        public void WakeUp()
        {

            Speed = saveSpeed;
            sleeping = false;
        }

        public override int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            if (sleeping == false)
            {
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
