using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力されたおつりの金額をstring型に代入し、int型に変える
            string otsuri = textBoxChange.Text;
            int Otsuri = Int32.Parse(otsuri);


            //計算
            //otsuri〇〇：それぞれのお札や硬貨の枚数
            //nokori〇〇：それぞれのお札や硬貨の枚数を計算した時点での残りのおつり金額
            int otsuri5000yen = Otsuri / 5000;
            int nokori5000yen = Otsuri % 5000;

            int otsuri1000yen = nokori5000yen / 1000;
            int nokori1000yen = nokori5000yen % 1000;

            int otsuri500yen = nokori1000yen / 500;
            int nokori500yen = nokori1000yen % 500;

            int otsuri100yen = nokori500yen / 100;
            int nokori100yen = nokori500yen % 100;

            int otsuri50yen = nokori100yen / 50;
            int nokori50yen = nokori100yen % 50;

            int otsuri10yen = nokori50yen / 10;
            int nokori10yen = nokori50yen % 10;

            int otsuri5yen = nokori10yen / 5;

            int otsuri1yen = nokori10yen % 5;



            //各テキストに代入
            label5000yen.Text = "X" + otsuri5000yen;
            label1000yen.Text = "X" + otsuri1000yen;
            label500yen.Text = "X" + otsuri500yen;
            label100yen.Text = "X" + otsuri100yen;
            label50yen.Text = "X" + otsuri50yen;
            label10yen.Text = "X" + otsuri10yen;
            label5yen.Text = "X" + otsuri5yen;
            label1yen.Text = "X" + otsuri1yen;
        }
    }
}
