using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWar
{
    // コンピュータ
    class Computer : Player
    {
        private Random random;
        // カードを引く範囲
        private int length;
        // 引いたカードを覚える
        private bool[] cards;

        // コンストラクター
        public Computer(int length)
        {
            random = new Random();
            this.length = length;
            cards = new bool[length];
        }

        // カードを無作為に引く
        //（返却値）引いたカードの添字
        public int DrawCard()
        {
            int n = -1;

            // 開いていないカードを探す
            while (n < 0)
            {
                n = random.Next(length);
                if (cards[n] == true)
                    n = -1;
            }
            // 開いていないカードを引く
            cards[n] = true;
            NowOpenCardIndex = n;
            return n;
        }

        // 引いたカードをクリアする
        public void CardsClear()
        {
            Array.Clear(cards, 0, cards.Length);
        }
    }
}
