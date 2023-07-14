using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Iwasi : Sakana
    {
        private bool sleeping;//睡眠中

        public Iwasi(int position_X, int position_Y,int speed,int moveWidth,System.Windows.Forms.PictureBox picture):base(position_X,position_Y,speed,moveWidth,picture)
        {
            sleeping = false;
        }

        //寝る
        public void Sleep()
        {
            sleeping = true;
        }

        //起きる
        public void WakeUp()
        {
            sleeping = false;
        }

        //餌を食べる
        public new int Fishing(int point,System.Windows.Forms.PictureBox mesi)
        {
            //起きてる間は食べる
            if (sleeping == false)
            {
                if (point <= 3)
                    point = base.Fishing(point,mesi);
                else
                    point = 0;
            }
            else
                point = 0;

            return point;
        }

    }
}
