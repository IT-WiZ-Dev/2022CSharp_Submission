using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWar
{
    // プレイヤークラス
    class Player
    {
        // コンストラクター
        public Player()
        {
            NowOpenCardIndex = -1;
            BeforeOpenCardIndex = -1;
            Score = 0;
        }

        // 開いたカードの添え字
        public int NowOpenCardIndex { get; set; }
        // 1つ前に開いたカードの添え字
        public int BeforeOpenCardIndex { get; set; }
        // 自分の点数
        public int Score { get; set; }

        // カードの情報をリセットする
        public void Reset()
        {
            BeforeOpenCardIndex = NowOpenCardIndex;
            NowOpenCardIndex = -1;
        }
    }
}
