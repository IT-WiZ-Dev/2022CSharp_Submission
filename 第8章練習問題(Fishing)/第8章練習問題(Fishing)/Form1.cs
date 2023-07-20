using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第8章練習問題_Fishing_
{
    public partial class Form1 : Form
    {
        //フィールド
        private Iwashi iwashi; //イワシクラス
        private Utsubo utsubo; //ウツボクラス
        private Ankou ankou; //アンコウクラス
        private int RTime = 600; //残り時間の60秒
        private bool dayTimeJudge = true; //昼時間かを判定する
        private int dayTime = DayTime;  //昼時間
        private int nightTime = NightTime; //よる時間
        private int score = 0; //スコア
        private const int iwashiSpeed = 20; //イワシのスピード
        private const int utsuboSpeed = 10; //ウツボのスピード
        private const int ankouSpeed = 10; //アンコウのスピード
        private const int DayTime = 100; //昼時間は10秒
        private const int NightTime = 50;//夜時間は5秒

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;
           



            //魚のインスタンス
            //イワシ
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwashi(x, y, iwashiSpeed, formSizeW, pictureBoxIwashi); //それぞれposX、posY、speed、formwidth、PictureBoxｇ入っている

            //ウツボ
            x = pictureBoxUtsubo.Location.X;
            y = pictureBoxUtsubo.Location.Y;
            utsubo = new Utsubo(x, y, utsuboSpeed, formSizeW, pictureBoxUtsubo);

            //アンコウ
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new Ankou(x, y, ankouSpeed, formSizeW, pictureBoxAnkou);
        }

        //泳ぐ
        private void swimFish()
        {
            //ピクチャーボックスの位置決め
            //イワシ
            iwashi.Swim(out int x1, out int y1);  //それぞれにfishクラスのswin(x,y)が入っている
            iwashi.PictureMove(x1, y1);

            //ウツボ
            utsubo.Swim(out int x2, out int y2);
            utsubo.PictureMove(x2, y2);

            //アンコウ
            ankou.Swim(out int x3, out int y3);
            ankou.PictureMove(x3, y3);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            //泳がせる
            swimFish();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //残り時間の表示
            RTime--;
            labelTime.Text = (RTime / 10) + "秒";

            if (dayTimeJudge == true) //昼時間の時の処理
            {
                dayTime--;

               
                if(dayTime == 0)  //昼時間が終わったときの処理
                {
                    dayTimeJudge = false; //ジャッジをfalse (= 夜)にする
                    iwashi.Sleep();  //イワシとウツボは寝る
                    utsubo.Sleep();
                    dayTime = DayTime;  //昼時間を10に戻す
                    BackColor = Color.DimGray; //背景色をDimGrayにする
                }
            }
            else //夜時間の時の処理
            {
                nightTime--;

                if(nightTime == 0) //夜時間が終わった時の処理
                {
                    dayTimeJudge = true; //ジャッジをtrue(= 昼)にする
                    iwashi.WakeUp();  //イワシとウツボを起こす
                    utsubo.WakeUp();
                    nightTime = NightTime;  //夜時間を5に戻す
                    BackColor = Color.LightSkyBlue;  //背景色をLightSkyBlueにする
                }
            }

            if(RTime / 10 == 0) //時間切れ
            {
                timer1.Stop();
                labelTime.Text = "終了！！";
            }
            else //時間がまだ残っている
            {
                swimFish();
            }
        }

        //Form1でキーが押されたときのイベントハンドラ
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 3以下の数字キーを押下した
            if (e.KeyChar <= '3')
            {
                // Convert the pressed key (char) to an integer value
                /*int keyNumber = int.Parse(e.KeyChar.ToString());*/

                // イワシが餌を食べる
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureEsaS);
                labelScore.Text = "得点：" + score;
            }
            else if(e.KeyChar >= '7')
            {
                //ウツボが餌を食べる
                score += utsubo.Eat(int.Parse(e.KeyChar.ToString()), pictureEsaM);
                labelScore.Text = "得点：" + score;
            }
            else if(e.KeyChar >= '4' && e.KeyChar <= '6')
            {
                //チョウチンアンコウが餌を食べる
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureEsaL);
                labelScore.Text = "得点：" + score;
            }
        }

        
    }
}
