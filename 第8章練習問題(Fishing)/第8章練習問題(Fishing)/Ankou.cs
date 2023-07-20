using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第8章練習問題_Fishing_
{
    class Ankou : Fish
    {
        //フィールド
        //ここでのアンコウは餌の大きさや昼夜問わず餌を食べるので無し

        //コンストラクタ
        public Ankou(int posX, int posY, int speed,int idouHaba, System.Windows.Forms.PictureBox pb)
            :base(posX, posY, speed,idouHaba,  pb)
        {

        }



        //プロパティ


        //メソッド
    }
}
