using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Sakana
    {
        private System.Windows.Forms.PictureBox picture;

        public Sakana(int position_X, int position_Y, int speed, int moveWidth, System.Windows.Forms.PictureBox picture)
        {
            Position_X = position_X;
            Position_Y = position_Y;
            Speed = speed;
            MoveWidth = moveWidth;
            this.picture = picture;
        }

        public int Position_X { get; set; }
        public int Position_Y { get; set; }
        public int Speed { get; set; }
        public int MoveWidth { get; set; }

        //泳ぎの処理
        public void Swiming(out int x, out int y)
        {
            Position_X += Speed;

            //画面外に行ったらループさせる
            if (Position_X > MoveWidth)
                Position_X = -picture.Size.Width;

            x = Position_X;
            y = Position_Y;
        }

        //つる処理
        public int Fishing(int point, System.Windows.Forms.PictureBox mesi)
        {
            //どのタイミングで連れるかの処理
            int overlap = (picture.Location.X + picture.Size.Width) - (mesi.Location.X + mesi.Size.Width);

            if (overlap >= 0 && overlap <= 30)
            {
                Position_X = -picture.Size.Width * 2;
                Move(Position_X, Position_Y);
            }
            else
                //釣れなかったら
                point = 0;

                return point;
            }

            //画像の移動
            public void Move(int x, int y)
            {
                picture.Location = new System.Drawing.Point(x, y);
            }

        }
    }

