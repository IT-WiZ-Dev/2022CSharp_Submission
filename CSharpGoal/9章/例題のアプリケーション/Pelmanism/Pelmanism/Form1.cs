using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism
{
    public partial class FormGame : Form
    {
        private Card[] playingCards;    // 遊ぶカードの束
        private Player player;          // プレイヤー
        private int gameSec;            // ゲーム時間

        public FormGame()
        {
            InitializeComponent();
        }

        // カード生成
        //（仮引数）cards：カード配列への参照
        private void CreateCards(ref Card[] cards)
        {
            string[] picture = {
                "○", "●", "△", "▲", "□", "■", "◇", "◆", "☆",
                "★", "※", "×"
            };

            // カードのインスタンスの生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        //「ゲームフォーム」ロードのイベントハンドラ
        private void FormGame_Load(object sender, EventArgs e)
        {
            // カードの生成
            CreateCards(ref playingCards);
            // プレイヤーの生成
            player = new Player();

            // カードをフォームに動的に配置する
            SuspendLayout();
            const int offsetX = 30, offsetY = 50;
            for (int i = 0; i < playingCards.Length; i++)
            {
                // カード（ボタン）のプロパティを設定する
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;
                playingCards[i].Location =
                    new Point(offsetX + i % 8 * sizeW,
                    offsetY + i / 8 * sizeH);
                // イベントハンドラに関連付け
                playingCards[i].Click
                += new EventHandler(CardButtons_Click);
            }
            Controls.AddRange(playingCards);
            ResumeLayout(false);

            labelGuidance.Text =
                "スタートボタンをクリックしてゲームを開始してください。";
        }

        // カードを混ぜる
        //（仮引数）cards：カードの配列
        private void ShuffleCard(Card[] cards)
        {
            Random r = new Random();

            int n = cards.Length - 1;
            while (n > 0)
            {
                int w = r.Next(0, n);
                string s = cards[n].Picture;
                cards[n].Picture = cards[w].Picture;
                cards[w].Picture = s;
                n--;
            }
        }

        //「スタートボタン」クリックのイベントハンドラ
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // カードを混ぜる
            ShuffleCard(playingCards);

            // 全部のカードを処理
            foreach (Card c in playingCards)
            {
                c.Close();  // カードを伏せる
            }

            buttonStart.Enabled = false;    // スタートボタン選択不可
            gameSec = 0;
            timer1.Start();

            labelGuidance.Text = "クリックしてカードをめくってください。";
        }

        //「タイマー」Tickのイベントハンドラ
        private void Timer1_Tick(object sender, EventArgs e)
        {
            gameSec++;
            labelSec.Text = gameSec + "秒経過";
        }

        // カードは全部開いたか
        //（仮引数）cards：カードの配列
        //（戻り値）true:全部表 false：1枚以上の裏のカードがある
        private bool AllOpenCard(Card[] cards)
        {
            foreach (Card c in cards)
            {
                if (c.State == false)
                    return false;
            }
            return true;
        }

        // カードは一致したか
        //（仮引数）cards：カードの配列
        // index1：1枚目のカードの添え字　index2：2枚目のカードの添え字
        //（戻り値）true：一致　false：不一致
        private bool MatchCard(Card[] cards, int index1, int index2)
        {
            if (index1 < 0 || index1 >= cards.Length ||
            index2 < 0 || index2 >= cards.Length)
                return false;

            if (cards[index1].Picture == cards[index2].Picture)
                return true;
            else
                return false;
        }

        //「カードボタン」クリックのイベントハンドラ
        private void CardButtons_Click(object sender, EventArgs e)
        {
            // めくるのは1枚目か？
            if (player.OpenCounter == 0)
            {
                // 前回のカードが不一致ならカードを伏せる
                int b1 = player.BeforeOpenCardIndex1;
                int b2 = player.BeforeOpenCardIndex2;
                if (b1 != -1 && b2 != -1
                    && MatchCard(playingCards, b1, b2) == false)
                {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }
                // クリックしたボタンのNameからカードの添え字を取得する
                int n1 = int.Parse(((Button)sender).Name.Substring(4));
                // 1枚目のカードを開く
                playingCards[n1].Open();
                player.NowOpenCardIndex1 = n1;

                labelGuidance.Text = "もう一枚めくってください。";
            }
            // めくるのは2枚目か？
            else if (player.OpenCounter == 1)
            {
                // クリックしたボタンのNameからカードの添え字を取得する
                int n2 = int.Parse(((Button)sender).Name.Substring(4));
                // 2枚目のカードを開く
                playingCards[n2].Open();
                player.NowOpenCardIndex2 = n2;
                // 1枚目と2枚目のカードは一致したか？
                if (MatchCard(playingCards, player.NowOpenCardIndex1,
                        player.NowOpenCardIndex2) == true)
                    labelGuidance.Text = "カードは一致しました。次のカードをめくってください。";
                else
                    labelGuidance.Text = "カードは不一致です。次のカードをめくってください。";
                
                // プレイヤーのカード情報をリセットする
                player.Reset();
                
                // 全カードをめくったか？
                if (AllOpenCard(playingCards))
                {
                    labelGuidance.Text = "全部のカードが一致しました。お疲れ様でした。";
                    timer1.Stop();
                    buttonStart.Enabled = true; // スタートボタン選択可
                }
            }
        }
    }
}
