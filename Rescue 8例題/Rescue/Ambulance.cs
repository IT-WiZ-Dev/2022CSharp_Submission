using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rescue
{
    //救急車クラス
    class Ambulance : Vehicle
    {
        private const int MinSpeed = 5; //最低スピード

        //コンストラクター
        public Ambulance(int positionX, int positionY, int speed,
            int distanceX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY,speed, distanceX, picture)
        {

        }

        //渋滞
        //(戻り値)現在のスピード
        public int TrafficJam()
        {
            //スピードを半分にする。ただし、最低スピード以下にはしない。
            Speed /= 2;
            if (Speed < MinSpeed)
                Speed = MinSpeed;

            return Speed;
        }
    }
}
