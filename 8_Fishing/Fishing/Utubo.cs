﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Utubo : Fish
    {
        private int saveSpeed;
        private bool sleeping;

        // コンストラクター
        public Utubo(int positionX, int positionY, int speed, int moveWidth,
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
                // 7より大きい餌
                if (point >= 7)
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
