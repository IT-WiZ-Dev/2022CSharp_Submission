using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class FormGame : Form
    {
        // フィールド
        private Anglerfish anglefish;                         // アンコウクラスのインスタンス
        private Sardine sardine;                              // イワシクラスのインスタンス
        private MorayEel moray;                            // ウツボクラスのインスタンス 

        private int remainingTime = 60;                 // 残り時間
        private int score = 0;                              // 得点
        private const int SardineSpeed = 20;       // イワシのスピード
        private const int MorayEeSpeed = 10;     // ウツボのスピード
        private const int AnglerfishSpeed = 10;  // アンコウのスピード
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;  // フォームのクライアント領域の幅

            int x = ankouPictureBox.Location.X;
            int y = ankouPictureBox.Location.Y;
            //アンコウクラスのインスタンス生成
            anglefish = new Anglerfish(x, y, AnglerfishSpeed, formSizeW, ankouPictureBox);

            x = iwashiPictureBox.Location.X;
            y = iwashiPictureBox.Location.Y;
            //イワシクラスのインスタンス生成
            sardine = new Sardine(x, y, SardineSpeed, formSizeW, iwashiPictureBox);

            x = utuboPictureBox.Location.X;
            y = utuboPictureBox.Location.Y;
            //ウツボクラスのインスタンス生成
            moray = new MorayEel(x, y, MorayEeSpeed, formSizeW, utuboPictureBox);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            if (remainingTime == 0)
            {
                remainingTime = 60;
            }
            timer1.Start();

            SwimFish();
        }

        private void SwimFish()
        {
            // 魚が泳ぎピクチャーボックスの位置を進める
            sardine.Swim(out int x1, out int y1);
            moray.Swim(out int x2, out int y2);
            anglefish.Swim(out int x3, out int y3);

            sardine.MovingWidth(x1, y1);
            moray.MovingWidth(x2, y2);
            anglefish.MovingWidth(x3, y3);
        }

        private void count_down(object sender, EventArgs e)
        {
            if (remainingTime == 0)
            {
                timer1.Stop();
                remaHourLabel.Text = "残り時間:60秒";
            }
            else
            {
                SwimFish();
            }

            if (remainingTime > 0)
            {
                remainingTime--;
                remaHourLabel.Text = "残り時間:" + remainingTime.ToString() + "秒";

                if (remainingTime == 45 || remainingTime == 30 || remainingTime == 15) //昼
                {
                    sardine.WakeUp();
                    moray.WakeUp();
                    this.BackColor = Color.White;

                }
                else if (remainingTime == 50 || remainingTime == 35 || remainingTime == 20 || remainingTime == 5) //夜
                {
                    sardine.Sleep();
                    moray.Sleep();
                    this.BackColor = Color.Gray;
                }
            }
        }

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字キーを押下した
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                // 餌を食べる
                score += anglefish.Eat(int.Parse(e.KeyChar.ToString()), esaMPictureBox);
                score += sardine.Eat(int.Parse(e.KeyChar.ToString()), esaSPictureBox);
                score += moray.Eat(int.Parse(e.KeyChar.ToString()), esaLPictureBox);


                scoreLabel.Text = "得点：" + score;
            }
        }

    }
}
