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
            int money, Gosen, Sen, Gohyaku, Hyaku, Gojyuu, Jyuu, Go, Iti;

            money = int.Parse(textBoxChange.Text);

            Gosen = money / 5000;
            money = money % 5000;
            Sen = money / 1000;
            money = money % 1000;
            Gohyaku = money / 500;
            money = money % 500;
            Hyaku = money / 100;
            money = money % 100;
            Gojyuu = money / 50;
            money = money % 50;
            Jyuu = money / 10;
            money = money % 10;
            Go = money / 5;
            Iti = money % 5;

            label5000yen.Text = Gosen.ToString();
            label1000yen.Text = Sen.ToString();
            label500yen.Text = Gohyaku.ToString();
            label100yen.Text = Hyaku.ToString();
            label50yen.Text = Gojyuu.ToString();
            label10yen.Text = Jyuu.ToString();
            label5yen.Text = Go.ToString();
            label1yen.Text = Iti.ToString();
        } 
    }
}
