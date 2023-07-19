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
            if (int.TryParse(textBoxChange.Text, out int changeAmount))
            {
                // 各お札と硬貨の枚数を計算
                int[] mon = money(changeAmount);

                // 枚数を表示
                label5000yen.Text = mon[0].ToString();
                label1000yen.Text = mon[1].ToString();
                label500yen.Text = mon[2].ToString();
                label100yen.Text = mon[3].ToString();
                label50yen.Text = mon[4].ToString();
                label10yen.Text = mon[5].ToString();
                label5yen.Text = mon[6].ToString();
                label1yen.Text = mon[7].ToString();
            }
        }

        private int[] money(int changeAmount)
        {
            int[] mon = new int[8];

            int[] x = { 5000, 1000, 500, 100, 50, 10, 5, 1 };

            for (int i = 0; i < x.Length; i++)
            {
                if (changeAmount >= x[i])
                {
                    mon[i] = changeAmount / x[i];
                    changeAmount %= x[i];
                }
            }

            return mon;
        }
    }
}
