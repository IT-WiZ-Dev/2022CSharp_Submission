using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // リストのインスタンスの生成
            List<string> sList = new List<string>();

            // 要素の追加
            sList.Add("First");
            sList.Add("Second");
            sList.Add("Third");

            // 要素の参照
            for (int i = 0; i < sList.Count; i++)
            {
                Console.WriteLine($"sList[{i}] : {sList[i]}");
            }
            Console.WriteLine();

            // リストの初期化
            List<int> iList = new List<int> { 1, 2, 3, 4, 5 };

            // 要素の参照
            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine($"iList[{i}] : {iList[i]}");
            }
            Console.WriteLine();

            // 先頭に要素100を追加
            iList.Insert(0, 100);
            // 要素4の削除
            iList.Remove(4);
            // 2番目の要素の削除
            iList.RemoveAt(2);

            // 要素の参照
            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine($"iList[{i}] : {iList[i]}");
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
