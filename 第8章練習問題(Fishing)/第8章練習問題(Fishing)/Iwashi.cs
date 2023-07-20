using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第8章練習問題_Fishing_
{
    class Iwashi : Fish
    {
        //フィールド
        private bool Nowsleep; //夜の時に寝ているかどうか
        private const int EsaMaxSize = 3; //餌の最大サイズ

        //コンストラクタ
        public Iwashi(int posX, int posY, int speed, int idouHaba, System.Windows.Forms.PictureBox pb)
            : base(posX, posY, speed, idouHaba, pb)
        {
            Nowsleep = false;
        }


        //プロパティ

        //寝るとき(寝ている時も回遊する)
        public void Sleep()
        {
            Nowsleep = true;
        }

        //起きるとき
        public void WakeUp()
        {
            Nowsleep = false;
        }


        //メソッド

        //餌を食べる
        public override int Eat(int point, System.Windows.Forms.PictureBox esa)
        {
            if (Nowsleep == false)
            {
                if (point <= EsaMaxSize)
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
