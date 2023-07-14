using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    //魚クラス
    internal class Fish
    {
        //フィールド
        // フィールド
        private System.Windows.Forms.PictureBox picture;
        private const int WidthMin = 0;
        private const int WidthMax = 30;

        //コンストラクタ―
        public Fish(int positionX, int positonY, int speed, int moveWidth, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positonY;
            Speed = speed;
            MoveWidth = moveWidth;
            this.picture = picture;
        }

        //プロパティ
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Speed { get; set; }
        public int MoveWidth { get; private set; }

        //メソッド
        public void Swim(out int x, out int y)
        {
            PositionX += Speed;


            if (PositionX > MoveWidth)
                PositionX = -picture.Size.Width;

            x = PositionX;
            y = PositionY;
        }

        public virtual int Eat(int point, System.Windows.Forms.PictureBox esa)
        {

            int overlap = (picture.Location.X + picture.Size.Width) -
                (esa.Location.X + esa.Size.Width);
            if (overlap >= WidthMin && overlap <= WidthMax)
            {

                PositionX = -picture.Size.Width * 2;
                MovingWidth(PositionX, PositionY);
            }
            else

                point = 0;

            return point;
        }

        public void MovingWidth(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
