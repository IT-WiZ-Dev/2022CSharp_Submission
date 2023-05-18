using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習問題P97
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //変数宣言
            const double Add = 0.1;
            int textboxzei = 0;
            int textboxhito = 0;
            int W = 0;
            int A = 0;
            double S = 0;

            //税込み金額の計算
            S = double.Parse(textBoxzeinuki.Text);
            S *= (1 + Add);
            textboxzei = (int)S;

            //一人あたりの金額と余りの計算
            textboxhito = int.Parse(textBoxninnzuu.Text);
            W = textboxzei / textboxhito;
            A = textboxzei % textboxhito;

            //結果表示
            labelwarikann.Text = W + "円";
            labelamari.Text = A + "円";





        }
    }
}
