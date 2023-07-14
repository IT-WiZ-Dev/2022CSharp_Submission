using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Utubo:Sakana
    {
        private int speed;
        private bool sleeping;

        public Utubo(int position_X,int position_Y,int speed, int moveWidth,System.Windows.Forms.PictureBox picture):base(position_X, position_Y, speed, moveWidth, picture)
        {
            this.speed = speed;
            sleeping = false;
        }

        public void Sleep()
        {
            base.Speed = 0;
            sleeping = true;
        }

        public void WakeUp()
        {
            // 起きたら泳ぐ
            base.Speed = this.speed;
            sleeping = false;
        }


        public new int Fishing(int point,System.Windows.Forms.PictureBox mesi)
        {
            if (sleeping == false)
            {
                if (point >= 7)
                    point = base.Fishing(point, mesi);
                else
                    point = 0;
            }
            else
                point = 0;
            return point;
        }
    }
}
