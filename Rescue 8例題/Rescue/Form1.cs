using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue
{
    public partial class FormGame : Form
    {
        private Helicopter helicopter;  //ヘリコプタークラスのインスタンス
        private Ambulance ambulance;    //救急車クラスのインスタンス
        private Motorcycle motorcycle;  //バイククラスのインスタンス
        private Random random;          //疑似乱数のインスタンス


        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            const int MotorcycleSpeed = 10;  //バイクのスピード
            const int AmbulanceSpeed = 15;   //救急車のスピード
            const int HelicopterSpeed = 30;  //ヘリコプターのスピード
            const int HelicopterMaxHigh = 30;  //ヘリコプターの最高速度

            //バイククラスのインスタンス生成
            int x = pictureBoxMotorcycle.Location.X;
            int y = pictureBoxMotorcycle.Location.Y;
            int distanceW = formSizeW - pictureBoxMotorcycle.Size.Width;
            motorcycle = new Motorcycle
                (x, y, MotorcycleSpeed, distanceW, pictureBoxMotorcycle);

            //救急車クラスのインスタンス生成
            x = pictureBoxAmbulance.Location.X;
            y = pictureBoxAmbulance.Location.Y;
            distanceW = formSizeW - pictureBoxAmbulance.Size.Width;
            ambulance = new Ambulance
                (x, y, AmbulanceSpeed, distanceW, pictureBoxAmbulance);

            //ヘリコプタークラスのインスタンス生成
            x = pictureBoxHelicopter.Location.X;
            y = pictureBoxHelicopter.Location.Y;
            distanceW = formSizeW - pictureBoxHelicopter.Size.Width;
            helicopter = new Helicopter(x, y,HelicopterSpeed,
                distanceW, pictureBoxHelicopter, HelicopterMaxHigh, y);

            random = new Random();   //乱数のインスタンス生成

            labelNotice.Text = "";
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            //乗り物を進める
            MoveVehicle();
        }

        //乗り物移動
        private void MoveVehicle()
        {
            //ヘリコプター、救急車、バイクの位置を進める
            bool rc1 = motorcycle.Run(out int x1, out int y1);
            bool rc2 = ambulance.Run(out int x2, out int y2);
            bool rc3 = helicopter.Run(out int x3, out int y3);

            //ピクチャボックスの位置を進める
            motorcycle.PictureMove(x1, y1);
            ambulance.PictureMove(x2, y2);
            helicopter.PictureMove(x3, y3);

            //全部の乗り物が到着したらタイマーを止める
            if(rc1 == false && rc2 == false && rc3 == false)
            {
                timer1.Stop();
                labelNotice.Text = "終了";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //乗り物を進める
            MoveVehicle();

            int r = random.Next(100);
            if (r == 0)
            {
                ambulance.TrafficJam();         //救急車に渋滞を通知
                labelNotice.Text += "渋滞発生";
            }
            else if (r == 50)
            {
                helicopter.Storm();             //ヘリコプターに嵐を通知
                labelNotice.Text += "嵐発生";
            }
        }
    }
}
