using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersLanguage
{
    // 花言葉作成クラス：花言葉を作成する静的クラス
    static class FlowerLanguage
    {
        // 花言葉を作成するメソッド
        //（仮引数）name：花の名前　color：花の色
        //（戻り値）作成した花言葉の文字列
        public static string Get(string name, string color)
        {
            Dictionary<string, string> flowers = FlowerFileIO.Read();

            // ファイルがなければエラーメッセージを返却
            if (flowers == null)
                return "花言葉ファイルがありません。";

            // ファイルの内容がなければエラーメッセージを返却
            if (flowers.Count <= 0)
                return "花言葉ファイルの中身が空です。";

            string searchKey;
            if (color != null && color != "")
            {
                // 色の指定がある場合には花の名前の後ろに色を付加
                searchKey = name + "(" + color + ")";
            }
            else
            {
                searchKey = name;
            }

            // 花の名前で辞書を検索
            if (flowers.ContainsKey(searchKey))
            {
                string language = flowers[searchKey];
                return searchKey + "の花ことばは「" + language + "」です。";
            }
            else
            {
                return searchKey + "の花ことばは登録されていません。";
            }
        }
    }
}
