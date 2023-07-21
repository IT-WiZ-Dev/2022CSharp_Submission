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
    public partial class Form1 : Form
    {
        private Sardine sardine; //イワシ
        private Moray moray; //ウツボ
        private Monkfish monkfish;//アンコウ
        private int rmgtime  = 600;//残り時間60秒
        private bool isDaytime = true;//昼間true 夜間false
        private int daytime = DayTime;//昼間の時間
        private int night = NightTime;//夜の時間
        private int score = 0;//得点
        private const int SardineSp = 30;//イワシのスピード
        private const int MoraySp = 20;//ウツボのスピード
        private const int MonkfishSp = 20;//アンコウのスピード
        private const int DayTime = 100;//昼間（１０秒）
        private const int NightTime = 50;//夜間（５秒）
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // キーボードイベントをフォームで処理するために必要

            // キーボードイベントハンドラを追加
            this.KeyPress += Form1_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSize = this.ClientSize.Width;//フォームの幅
            //イワシのインスタンス
            int x = pictureBoxIwasi.Location.X;
            int y = pictureBoxIwasi.Location.Y;
            sardine = new Sardine(x, y, SardineSp, formSize, pictureBoxIwasi);
            //ウツボのインスタンス
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            moray = new Moray(x, y, MoraySp, formSize, pictureBoxUtubo);
            //アンコウのインスタンス
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            monkfish = new Monkfish(x, y, MonkfishSp, formSize, pictureBoxAnkou);
        }
        
        private void SwimFish()
        {

            sardine.Swing(out int x1, out int y1);
            sardine.PbMove(x1, y1);
            moray.Swing(out int x2, out int y2);
            moray.PbMove(x2, y2);
            monkfish.Swing(out int x3, out int y3);
            monkfish.PbMove(x3, y3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            SwimFish();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //残り時間
            rmgtime--;
            label1.Text = "残り時間：" + (rmgtime / 10) + "秒";

            if (isDaytime == true)//昼間
            {
                daytime--;

                if (daytime == 0)//昼間と夜間を切り替え
                {
                    isDaytime = false;//夜にする
                    sardine.Sleep();
                    moray.Sleep();
                    daytime = DayTime;//昼間の時間を初期化
                    BackColor = Color.Navy;
                }
            } else//夜
            {
                night--;
                if (night == 0)//昼間と夜間を切り替え
                {
                    isDaytime = true;//昼間にする
                    sardine.Getup();
                    moray.Getup();
                    night = NightTime;//夜の時間を初期化
                    BackColor = Color.CornflowerBlue;
                }
            }

            //時間切れ
            if (rmgtime / 10 == 0)
            {
                timer1.Stop();
                label1.Text = "ゲームオーバー";
            }
            else
            {
                SwimFish();
            }
        }

            private void Form1_KeyPress(object sender, KeyPressEventArgs e)
            {
                // 数字キーを押下した
                if (e.KeyChar >= '1' && e.KeyChar <= '9')
                {
                    // 餌を食べる
                    score += sardine.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxIwashiesa);
                    score += moray.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxUtuboesa);
                    score += monkfish.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxAnkouesa);

                    label2.Text = "得点：" + score;
                }
        }
    }
}
