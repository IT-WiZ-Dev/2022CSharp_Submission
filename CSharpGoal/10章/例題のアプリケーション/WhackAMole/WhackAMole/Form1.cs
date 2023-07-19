using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMole
{
    public partial class FormGame : Form
    {
        private JumpAnimal[] jumpAnimal;    // 飛び出す動物のインスタンス
        private int remainingTime;          // 残り時間
        private int jumpInterval;           // ジャンプする間隔
        private Random random;

        public FormGame()
        {
            InitializeComponent();
        }

        //「ゲームフォーム」ロードのイベントハンドラ
        private void FormGame_Load(object sender, EventArgs e)
        {
            jumpAnimal = new JumpAnimal[4];

            // Formのクライアント領域の高さ
            int formSizeH = ClientSize.Height;

            // 鳥クラスのインスタンスをjumpAnimalの配列に登録
            jumpAnimal[0] = new Bird(50, formSizeH, 40);
            // 猫クラスのインスタンスをjumpAnimalの配列に登録
            jumpAnimal[1] = new Cat(256, formSizeH, 20);
            // モグラクラスのインスタンスをjumpAnimalの配列に登録
            jumpAnimal[2] = new Mole(450, formSizeH, 10);
            // ウサギクラスのインスタンスをjumpAnimalの配列に登録
            jumpAnimal[3] = new Rabbit(600, formSizeH, 30);

            random = new Random(); // 乱数のインスタンス生成

            SuspendLayout();

            for (int i = 0; i < jumpAnimal.Length; i++)
            {
                // PictureBoxのNameを設定（"animal0" ～ "animal3"）
                jumpAnimal[i].Name = "animal" + i.ToString();
                // イベントハンドラに関連付け
                jumpAnimal[i].Click
                    += new EventHandler(JumpAnimal_Click);
            }
            Controls.AddRange(jumpAnimal);
            ResumeLayout(false);
        }

        //「スタートボタン」クリックのイベントハンドラ
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            remainingTime = 60;
            timerJump.Interval = 100;
            jumpInterval = 50;
            JumpAnimal.Score = 0;

            labelScore.Text = "得点：" + JumpAnimal.Score;
            labelTime.Text = "残り時間：" + remainingTime + "秒";

            timerJump.Start();
            timerTime.Start();
        }

        //「ジャンプ用タイマー」Tickのイベントハンドラ
        private void TimerJump_Tick(object sender, EventArgs e)
        {
            // 不定期にジャンプスタート
            int n = random.Next(jumpInterval);
            if (n >= 0 && n < jumpAnimal.Length)
                jumpAnimal[n].Jumping = true;

            foreach (JumpAnimal obj in jumpAnimal)
            {
                // ジャンプ中ならジャンプ
                if (obj.Jumping == true)
                    obj.Jump();
            }
        }

        //「飛び出す動物のPictureBox」クリックのイベントハンドラ
        private void JumpAnimal_Click(object sender, EventArgs e)
        {
            // 添え字を取得
            int n = int.Parse(((PictureBox)sender).Name.Substring(6));

            // ヒット処理
            int score = jumpAnimal[n].Hit();
            labelScore.Text = "得点：" + score;
        }

        //「残り時間用のタイマー」Tickのイベントハンドラ
        private void TimerTime_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = "残り時間：" + remainingTime + "秒";

            // ゲームオーバー
            if (remainingTime <= 0)
            {
                timerJump.Stop();
                timerTime.Stop();

                labelTime.Text = "ゲームオーバー";

                // PictureBoxを穴に隠す
                foreach (JumpAnimal obj in jumpAnimal)
                {
                    obj.Location = new Point(obj.HoleX, obj.HoleY);
                }

                buttonStart.Enabled = true;
            }

            // 10秒ごとに
            if (remainingTime % 10 == 0)
            {
                // ジャンプ間隔を早める
                timerJump.Interval -= 7;
                // ジャンプ頻度を高める
                jumpInterval -= 7;
            }
        }
    }
}
