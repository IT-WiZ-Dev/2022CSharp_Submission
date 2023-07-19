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
          NewModel newModel = new NewModel(123, "Example");

        }

    }


    // 継承元の BaseModel、変更してはいけません。

    class BaseModel

    {

        public BaseModel(int num, string name)

        {
        }

    }


    class NewModel : BaseModel

    {

        public NewModel(int num, string name) : base(num, name)

        { 
        }

    }

}
