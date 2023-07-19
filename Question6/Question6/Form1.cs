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
            //クラスの継承とかやりたかったけどあきらめました

            int money = int.Parse(textBoxChange.Text);

            //5000円札
            int count = 0;
            while (money >= 5000)
            {
                money -= 5000;
                count += 1;
            }
            
            label5000yen.Text = count.ToString();

            //1000円札
            count = 0;
            while (money >= 1000)
            {
                money -= 1000;
                count += 1;
            }
            label1000yen.Text = count.ToString();

            //500円硬貨
            count = 0;
            while (money >= 500)
            {
                money -= 500;
                count += 1;
            }
            label500yen.Text = count.ToString();

            //100円硬貨
            count = 0;
            while (money >= 100)
            {
                money -= 100;
                count += 1;
            }
            label100yen.Text = count.ToString();

            //50円硬貨
            count = 0;
            while (money >= 50)
            {
                money -= 50;
                count += 1;
            }
            label50yen.Text = count.ToString();

            //10円硬貨
            count = 0;
            while (money >= 10)
            {
                money -= 10;
                count += 1;
            }
            label10yen.Text = count.ToString();

            //5円硬貨
            count = 0;
            while (money >= 5)
            {
                money -= 5;
                count += 1;
            }
            label5yen.Text = count.ToString();

            //1円硬貨
            count = 0;
            while (money >= 1)
            {
                money -= 1;
                count += 1;
            }
            label1yen.Text = count.ToString();
        }
    }
}
