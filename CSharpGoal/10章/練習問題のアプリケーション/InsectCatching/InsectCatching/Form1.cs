using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    public partial class FormGame : Form
    {
        // フィールド
        private Insect[] insect;            // 虫の配列
        private int counter;                // 現在出現中の虫の数
        private int remainingTime;          // 残り時間
        private const int InsectKind = 3;   // 虫の種類
        private const int InsectCount = 61; // 虫は61匹
        private Random random;

        public FormGame()
        {
            InitializeComponent();
        }

        //「ゲームフォーム」ロードのイベントハンドラ
        private void FormGame_Load(object sender, EventArgs e)
        {
            insect = new Insect[InsectCount];

            random = new Random();

            int formSizeW = ClientSize.Width;       // Formのクライアント領域の幅
            int formSizeH = ClientSize.Height;      // Formのクライアント領域の高さ

            for (int i = 0; i < insect.Length; i++)
            {
                // 3種類61匹分の昆虫をランダムに用意する
                switch (random.Next(0, InsectKind))
                {
                    case 0:
                        insect[i] = new Beetle(formSizeW, formSizeH, random);
                        break;
                    case 1:
                        insect[i] = new Butterfly(formSizeW, formSizeH, random);
                        break;
                    case 2:
                        insect[i] = new Dragonfly(formSizeW, formSizeH, random);
                        break;
                }
            }

            SuspendLayout();
            for (int i = 0; i < insect.Length; i++)
            {
                // ピクチャーボックスのNameを設定
                insect[i].Name = "insect" + i.ToString();
                // イベントハンドラに関連付け
                insect[i].Click += new EventHandler(Insect_Click);
            }
            Controls.AddRange(insect);
            ResumeLayout(false);
        }
        
        // 「スタートボタン」クリックのイベントハンドラ
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            remainingTime = 60;
            timerTime.Start();
            timerInsect.Start();
            Insect.Score = 0;
            counter = 0;

            // 全部の虫の位置を初期化
            foreach (Insect i in insect)
            {
                i.Reset();
            }

            // 最初の1匹が逃げる
            insect[counter].Visible = true;
            insect[counter++].RunAway();

            labelScore.Text = "得点：" + Insect.Score;
            labelTime.Text = "残り時間：" + remainingTime + "秒";
        }

        // 「残り時間用タイマー」のTickイベントハンドラ
        private void TimerTime_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = "残り時間：" + remainingTime + "秒";

            // ゲームオーバー
            if (remainingTime <= 0)
            {
                timerInsect.Stop();
                timerTime.Stop();

                labelTime.Text = "ゲームオーバー";
                buttonStart.Enabled = true;

                // 全部の虫を非表示にする
                foreach (Insect i in insect)
                {
                    i.Visible = false;
                }
            }
            else
            {
                // 1秒ごとに1匹出現
                counter++;
                insect[counter].Visible = true;
                insect[counter].RunAway();
            }
        }

        // 「虫用タイマー」のTickイベントハンドラ
        private void TimerInsect_Tick(object sender, EventArgs e)
        {
            // 出現中の虫は全部逃げる
            for (int i = 0; i < counter; i++)
            {
                insect[i].RunAway();
            }
        }

        // ピクチャーボックスクリックのイベントハンドラ
        private void Insect_Click(object sender, EventArgs e)
        {
            // 添字を取得
            int n = int.Parse(((PictureBox)sender).Name.Substring(6));

            // ヒット処理
            int score = insect[n].Hit();
            labelScore.Text = "得点：" + score;
        }
    }
}
