using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問5
 * 下記でクラスBaseModelが定義されている。
 * BaseModelを継承した派生クラスNewModelを作成してください。
 * ※　エラーが出てる場合は不正解
 * ※　クラスBaseModel内は変更してはいけない。
*/


namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //熊田晃大
    class NewModel : BaseModel
    {
        public NewModel(int num, string name) : base(num, name)
        {
            //派生クラス
        }
    }

    // 継承元のBaseModel、変更してはいけません。
    class BaseModel
    {
        public BaseModel(int num, string name)
        {

        }
    }


}
