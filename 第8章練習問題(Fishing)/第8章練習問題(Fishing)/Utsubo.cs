using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第8章練習問題_Fishing_
{
    class Utsubo : Fish
    {
        //フィールド
        private int saveSpeed;
        private bool Nowsleep;
        private const int EsaMinSize = 7;

        //コンストラクタ
        public Utsubo(int posX, int posY, int speed, int idouHaba, System.Windows.Forms.PictureBox pb)
            : base(posX, posY, speed, idouHaba, pb)
        {
            saveSpeed = speed;
            Nowsleep = false;

        }


        //プロパティ

        //寝るとき
        public void Sleep()
        {
            Speed = 0;
            Nowsleep = true;
        }

        //起きるとき
        public void WakeUp()
        {
            Speed = saveSpeed;
            Nowsleep = false;
        }

        //メソッド

        //餌を食べるメソッド
        public override int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            //起きているときのみ
            if (Nowsleep == false)
            {
                if (point >= EsaMinSize)
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
