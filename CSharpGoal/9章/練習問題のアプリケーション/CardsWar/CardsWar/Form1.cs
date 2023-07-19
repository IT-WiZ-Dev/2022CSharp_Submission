using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsWar
{
    public partial class FormGame : Form
    {
        private Card[] cards;               // 遊ぶカード（配る前）
        private Card[] userCards;           // 遊ぶカード（ユーザ側）
        private Card[] computerCards;       // 遊ぶカード（コンピュータ側）
        private Player user;                // ユーザー
        private Computer computer;          // コンピュータ

        public FormGame()
        {
            InitializeComponent();
        }

        // カードの生成
        //（仮引数）cards：カード配列への参照
        private void CreateCards(ref Card[] cards)
        {
            string[] picture = {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            };

            // カードのインスタンスの生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        // カードを混ぜる
        //（仮引数）cards：カードの配列
        private void ShuffleCard(Card[] cards)
        {
            Random r = new Random();
            int n = cards.Length - 1;

            // シャッフル
            while (n > 0)
            {
                int w = r.Next(0, n);
                string s = cards[n].Picture;
                cards[n].Picture = cards[w].Picture;
                cards[w].Picture = s;
                n--;
            }
        }

        // カードは全部開いたか
        //（仮引数）cards：カードの配列
        //（返却値）true:全部表 false：1枚以上の裏のカードがある
        private bool AllOpen(Card[] cards)
        {
            foreach (Card c in cards)
            {
                if (c.State == false)
                    return false;
            }
            return true;
        }

        // カードの勝敗判定
        //（仮引数）cards1：カード1の配列, index1：カード1の添字
        //　　　　　cards2：カード2の配列, index2：カード2の添字
        //（返却値）点数（0：カード1の負け　1：引き分け　2：カード1の勝ち）
        private int Judge(Card[] cards1, int index1, Card[] cards2, int index2)
        {
            if (index1 < 0 || index1 >= cards1.Length ||
                index2 < 0 || index2 >= cards2.Length)
                return 0;

            // カードの絵柄から点数を算出する
            string[] pictures = {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            };
            int[] scores = {
                14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
            };

            int score1 = 0;
            for (int i = 0; i <= pictures.Length; i++)
            {
                if (cards1[index1].Picture == pictures[i])
                {
                    score1 = scores[i];
                    break;
                }
            }

            int score2 = 0;
            for (int i = 0; i <= pictures.Length; i++)
            {
                if (cards2[index2].Picture == pictures[i])
                {
                    score2 = scores[i];
                    break;
                }
            }

            // 判定する
            if (score1 == score2)
                return 1;   // 引き分け
            else if (score1 > score2)
                return 2;   // 勝ち
            else
                return 0;   // 負け
        }

        //「ゲームフォーム」ロードのイベントハンドラ
        private void FormGame_Load(object sender, EventArgs e)
        {
            // カードの生成
            CreateCards(ref cards);

            // カードをシャッフルする
            ShuffleCard(cards);

            // カードを分ける
            userCards = new Card[cards.Length / 2];
            computerCards = new Card[cards.Length / 2];
            Array.Copy(cards, userCards, userCards.Length);
            Array.Copy(cards, userCards.Length, computerCards, 0, computerCards.Length);

            // プレイヤーの生成
            user = new Player();
            computer = new Computer(computerCards.Length);

            // コンピュータのカードをフォームに並べる
            SuspendLayout();
            int offsetX = 130, offsetY = 30;
            for (int i = 0; i < computerCards.Length; i++)
            {
                // カード（ボタン）のプロパティを設定する
                computerCards[i].Name = "computerCards" + i.ToString();
                int sizeW = computerCards[i].Size.Width;
                computerCards[i].Location = new Point(offsetX + i * sizeW, offsetY);
            }
            Controls.AddRange(computerCards);

            // ユーザのカードをフォームに並べる
            offsetY = 240;
            for (int i = 0; i < userCards.Length; i++)
            {
                // カード（ボタン）のプロパティを設定する
                userCards[i].Name = "userCards" + i.ToString();
                int sizeW = userCards[i].Size.Width;
                userCards[i].Location = new Point(offsetX + i * sizeW, offsetY);
                // ユーザのカードだけイベントハンドラに関連付け
                userCards[i].Click += new EventHandler(CardButtons_Click);
                userCards[i].Enabled = true;
            }
            Controls.AddRange(userCards);
            ResumeLayout(false);

            labelGuidance.Text = "カードを選んでください。";
            buttonRestart.Enabled = false;
        }

        // カードButtonのクリックイベントハンドラ
        private void CardButtons_Click(object sender, EventArgs e)
        {
            // ユーザのカードの添字を取得
            int n1 = int.Parse(((Button)sender).Name.Substring(9));

            // 前のカードをリセットして表示をグレイにする
            user.Reset();
            computer.Reset();
            if (user.BeforeOpenCardIndex != -1)
                userCards[user.BeforeOpenCardIndex].BackColor = Color.LightGray;
            if (computer.BeforeOpenCardIndex != -1)
                computerCards[computer.BeforeOpenCardIndex].BackColor = Color.LightGray;

            // カードを開く
            user.NowOpenCardIndex = n1;
            userCards[n1].Open();

            // コンピュータがカードを引く
            int n2 = computer.DrawCard();
            computerCards[n2].Open();

            // 勝敗を判定する
            int score = Judge(userCards, n1, computerCards, n2);
            if (score == 0)
            {
                labelGuidance.Text = "コンピュータの勝ちです。次のカードを選んでください。";
                computer.Score += 2;
            }
            else if (score == 1)
            {
                labelGuidance.Text = "引き分けです。次のカードを選んでください。";
                user.Score += score;
                computer.Score += score;
            }
            else
            {
                labelGuidance.Text = "あなたの勝ちです。次のカードを選んでください。";
                user.Score += score;
            }

            // 得点を更新する
            labelComScore.Text = "得点 ： " + computer.Score;
            labelUserScore.Text = "得点 ： " + user.Score;

            // 全部開いたか
            if (AllOpen(userCards) == true)
            {
                if (user.Score == computer.Score)
                    labelGuidance.Text = "引き分けです。お疲れ様でした。";
                else if (user.Score > computer.Score)
                    labelGuidance.Text = "あなたの勝ちです。お疲れ様でした。";
                else
                    labelGuidance.Text = "コンピュータの勝ちです。お疲れ様でした。";

                buttonRestart.Enabled = true;
            }
        }

        // 再挑戦ボタンクリックのイベントハンドラ
        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            // カードをシャッフルする
            ShuffleCard(cards);

            // カードを分ける
            Array.Copy(cards, userCards, userCards.Length);
            Array.Copy(cards, userCards.Length, computerCards, 0, computerCards.Length);

            // 全部のカードを伏せる
            foreach (Card c in userCards)
            {
                c.Close();
            }
            foreach (Card c in computerCards)
            {
                c.Close();
            }

            // ユーザとコンピュータの状態をリセットする
            user.Reset();
            user.Score = 0;
            computer.Reset();
            computer.CardsClear();
            computer.Score = 0;

            labelComScore.Text = computer.Score.ToString();
            labelUserScore.Text = user.Score.ToString();

            labelGuidance.Text = "カードを選んでください。";
            buttonRestart.Enabled = false;
        }
    }
}
