using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InsectCatching
{
    // 昆虫クラス
    abstract class Insect : PictureBox
    {
        public Insect(int x, int y, int moveWidth, int moveHeight, Image image)
        {
            Location = new Point(x, y);
            MoveWidth = moveWidth;
            MoveHeight = moveHeight;
            Image = image;
            SizeMode = PictureBoxSizeMode.AutoSize;
            Visible = false;    // ピクチャーボックスは最初非表示
        }

        public static int Score { get; set; }           // 得点
        public int MoveWidth { get; private set; }      // 移動範囲幅
        public int MoveHeight { get; private set; }     // 移動範囲高さ

        // 逃げる
        public abstract void RunAway();

        // 位置をリセットする
        public abstract void Reset();

        // 当たった
        //（返却値）更新した得点
        public int Hit()
        {
            // ピクチャーボックスを消す
            Visible = false;

            // 加点する
            Score++;

            return Score;
        }
    }
}
