using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    //アンコウクラス
    internal class Anglerfish : Fish
    {
        // コンストラクター
        public Anglerfish(int positionX, int positionY, int speed, int moveWidth,
            System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, moveWidth, picture)
        {

        }
    }
}
