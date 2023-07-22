using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第8章_練習問題
{
    public partial class Form1 : Form
    {
        //フィールド
        private Iwashi iwashi;//インスタンス
        private Utubo utubo;//インスタンス
        private Anko anko;//インスタンス
        private int nokoriTime = 600;//残り時間(60秒*1000秒/100m周期)
        private bool hiruTime = true;//trueはお昼
        private int daytime = DayTime;//昼
        private int night = NightTime;//夜
        private int score = 0;
        //コンテキスト
        private const int IwashiSpeed = 20;
        private const int UtuboSpeed = 10;
        private const int AnkoSpeed = 10;
        private const int DayTime = 100;
        private const int NightTime = 50;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;

            //フォームのクライアント領域の幅
            int formSizeW = this.ClientSize.Width;

            //お魚のインスタンスの生成
            //いわし
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwashi(x, y, IwashiSpeed, formSizeW, pictureBoxIwashi);
            //ウツボ
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new Utubo(x, y, UtuboSpeed, formSizeW, pictureBoxUtubo);
            //アンコウ
            x = pictureBoxAnko.Location.X;
            y = pictureBoxAnko.Location.Y;
            anko = new Anko(x, y, UtuboSpeed, formSizeW, pictureBoxAnko);

        }

        //泳ぐ
        private void SwimFish()
        {
            //魚が泳いでピクチャーボックスの位置を進める
            //いわし
            iwashi.Run(out int x1, out int y1);
            iwashi.PictureMove(x1, y1);
            //ウツボ
            utubo.Run(out int x2, out int y2);
            utubo.PictureMove(x2, y2);
            //アンコウ
            anko.Run(out int x3, out int y3);
            anko.PictureMove(x3, y3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //お魚を進める
            SwimFish();
        }

        //private void MoveVehicle(){}

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 残り時間の表示（100ms単位で起動されるので10で割る）
            nokoriTime--;
            label1.Text = "残り時間：" + (nokoriTime / 10) + "秒";

            if (hiruTime == true)  // 昼間
            {
                daytime--;
                // 昼間終わり
                if (daytime == 0)
                {
                    hiruTime = false;      // 夜にする
                    iwashi.Sleep();         // イワシは寝る
                    utubo.Sleep();          // ウツボは寝る
                    //アンコウは寝ない
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
                    hiruTime = true;       // 昼間にする
                    iwashi.WakeUp();        // イワシは起きる
                    utubo.WakeUp();         // ウツボは起きる
                    night = NightTime;      // 夜の時間の初期化
                    BackColor = Color.CornflowerBlue;
                }
            }

            // 時間切れ
            if (nokoriTime / 10 == 0)
            {
                //タイマーが0になったら止まってgameobera
                timer1.Stop();
                label1.Text = "ゲームオーバー";
            }
            else
            {
                //0になるまでゲーム継続
                // 魚が泳ぐ
                SwimFish();
            }
        }

        //「ゲームフォーム」キー押下のイベントハンドラ
        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字キーを押下した
            //押したキーが1以上かつ9以下
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                // 餌を食べる(小・中・大)
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxM1);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxM2);
                score += anko.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxM3);

                label2.Text = "得点：" + score;
            }
        }

        private void pictureBoxM1_Click(object sender, EventArgs e)
        {

        }
    }
}

