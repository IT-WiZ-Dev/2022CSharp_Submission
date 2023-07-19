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
            int money = int.Parse(textBoxChange.Text);

            //5千円
            int b5k = money / 5000;
            money = money % 5000;

            //千円
            int b1k = money / 1000;
            money = money % 1000;

            //500円
            int c500 = money / 500;
            money = money % 500;

            //100円
            int c100 = money / 100;
            money = money % 100;

            //50円
            int c50 = money / 50;
            money = money % 50;

            //10円
            int c10 = money / 10;
            money = money % 10;

            //5円
            int c5 = money / 5;

            //1円
            int c1 = money % 5;

            label5000yen.Text = b5k.ToString();
            label1000yen.Text = b1k.ToString();
            label500yen.Text = c500.ToString();
            label100yen.Text = c100.ToString();
            label50yen.Text = c50.ToString();
            label10yen.Text = c10.ToString();
            label5yen.Text = c5.ToString();
            label1yen.Text = c1.ToString();

        }
    }
}
