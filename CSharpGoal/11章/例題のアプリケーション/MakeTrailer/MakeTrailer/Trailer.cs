using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTrailer
{
    // 予告クラス
    static class Trailer
    {
        private static Random random = new Random();

        // 予告を作成するメソッド
        //（仮引数）nameA：名前A　nameB：名前B　nameC：名前C
        //（戻り値）作成した予告の文字列
        public static string Get(string nameA, string nameB, string nameC)
        {
            string content;

            // 予告をファイルから入力する
            List<string> contentsList = ContentsFileIO.Read();

            // ファイルがなければエラーメッセージを返却
            if (contentsList == null)
                return "予告ファイルがありません。";

            // ファイルの内容がなければエラーメッセージを返却
            if (contentsList.Count <= 0)
                return "予告ファイルに予告がありません。";

            // 予告をランダムに1つ選ぶ
            int index = random.Next(contentsList.Count);
            content = contentsList[index];

            // 友達の名前で書き換える
            content = content.Replace(",", Environment.NewLine);
            content = content.Replace("[人物A]", nameA);
            content = content.Replace("[人物B]", nameB);
            content = content.Replace("[人物C]", nameC);

            return content;
        }
    }
}
