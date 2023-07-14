using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Iwashi : Fish
    {
        //フィールド
        private bool sleeping;

        //コンストラクタ
        public Iwashi(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, distanceX, picture)
        {
            sleeping = false;
        }

        public void Sleep()
        {
            sleeping = true;
        }

        public void WakeUp()
        {
            sleeping = false;
        }

        //餌を食べる
        public override int EatFeed(int number, System.Windows.Forms.PictureBox feed)
        {
            if(sleeping == false)
            {
                if(sleeping == false)
                {
                    if(number <= 3)
                    {
                        number = base.EatFeed(number, feed);
                    }
                    else
                    {
                        number = 0;
                    }
                }
            }
            else
            {
                number = 0;
            }
            return number;
        }
    }
}
