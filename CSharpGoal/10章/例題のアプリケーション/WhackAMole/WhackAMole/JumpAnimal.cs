using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WhackAMole
{
    // 飛び出す動物クラス
    abstract class JumpAnimal : PictureBox
    {
        // コンストラクター
        public JumpAnimal(int holeX, int holeY, int speed, Image image)
        {
            Location = new Point(holeX, holeY);
            HoleX = holeX;
            HoleY = holeY;
            Speed = speed;
            Jumping = false;
            Image = image;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        // プロパティ
        public static int Score { get; set; }       // 得点
        public int HoleX { get; private set; }      // 穴の左上x座標
        public int HoleY { get; private set; }      // 穴の左上y座標
        public int Speed { get; protected set; }    // ジャンプのスピード
        public bool Jumping { get; set; }           // ジャンプ中か否か

        // 飛び出す
        public abstract void Jump();
        // 当たった
        public abstract int Hit();
    }
}
