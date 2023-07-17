using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class FormGame : Form
    {
        // フィールド
        private Iwasi iwasi;              // イワシクラス
        private Utubo utubo;                // ウツボクラス
        private ankou ankou;                // アンコウクラス
        private int remainingTime = 600;    // 残り時間
        private bool isDayTime = true;      // 昼間はtrue
        private int daytime = DayTime;      // 昼間の時間
        private int night = NightTime;      // 夜の時間
        private int score = 0;              // スコア
        private const int IwasiSpeed = 20; // イワシのはやさ
        private const int UtuboSpeed = 10;  // ウツボのはやさ
        private const int ankouSpeed = 10;  // アンコウのはやさ
        private const int DayTime = 100;    // 昼間の時間
        private const int NightTime = 50;   // 夜の時間
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;
            // 魚のインスタンスの生成
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwasi = new Iwasi(x, y, IwasiSpeed, formSizeW, pictureBoxIwashi);
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new Utubo(x, y, UtuboSpeed, formSizeW, pictureBoxUtubo);
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new ankou(x, y, ankouSpeed, formSizeW, pictureBoxAnkou);
        }

        private void SwimFish()
        {
            // 魚動き
            iwasi.Swim(out int x1, out int y1);
            iwasi.PictureMove(x1, y1);
            utubo.Swim(out int x2, out int y2);
            utubo.PictureMove(x2, y2);
            ankou.Swim(out int x3, out int y3);
            ankou.PictureMove(x3, y3);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            // 魚が泳ぐ
            SwimFish();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 残り時間の表示（100ms単位で起動されるので10で割る）
            remainingTime--;
            labelTimer.Text = "残り時間：" + (remainingTime / 10) + "秒";

            if (isDayTime == true)  // 昼間
            {
                daytime--;
                // 昼間終わり
                if (daytime == 0)
                {
                    isDayTime = false;      // 夜にする
                    iwasi.Sleep();         // イワシは寝る
                    utubo.Sleep();          // ウツボは寝る
                    daytime = DayTime;      // 昼間の時間の初期化
                    BackColor = Color.Navy;
                }
            }
            else // 夜
            {
                night--;
                // 夜終わり
                if (night == 0)
                {
                    isDayTime = true;       // 昼間にする
                    iwasi.WakeUp();        // イワシは起きる
                    utubo.WakeUp();         // ウツボは起きる
                    night = NightTime;      // 夜の時間の初期化
                    BackColor = Color.CornflowerBlue;
                }
            }

            // 時間切れ
            if (remainingTime / 10 == 0)
            {
                timer1.Stop();
                labelTimer.Text = "ゲームオーバー";
            }
            else
            {
                // 魚が泳ぐ
                SwimFish();
            }
        }

        //お手上げ。全然わからなかったので、欲に目がくらみました
    }
    }


