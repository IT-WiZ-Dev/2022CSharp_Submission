using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    class Utsubo : Fish
    {
        //フィールド
        private int tmp;
        private bool sleeping;

        //コンストラク
        public Utsubo(int positionX, int positionY, int speed, int distanceX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, distanceX, picture)
        {
            tmp = speed;
            sleeping = false;
        }

        public void Sleep()
        {
            Speed = 0;
            sleeping = true;
        }

        public void WakeUp()
        {
            Speed = tmp;
            sleeping = false;
        }

        //餌を食べる
        public override int EatFeed(int number, System.Windows.Forms.PictureBox feed)
        {
            if(sleeping == false)
            {
                if(number >= 7)
                {
                    number = base.EatFeed(number, feed);
                }
                else
                {
                    number = 0;
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
