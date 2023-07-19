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
          int[] amount = {5000,1000,500,100,50,10,5,1};
          int[] count = {0,0,0,0,0,0,0,0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBoxChange.Text);
            for (int i = 0; i < 8; i++)
            {
                while (money >= amount[i])
                {
                    money = money - amount[i];
                    Console.WriteLine(money);
                    count[i]++;

                    switch (amount[i])
                    {
                        case 5000:
                            label5000yen.Text = count[i].ToString();
                            continue;
                        case 1000:
                            label1000yen.Text = count[i].ToString();
                            continue;
                        case 500:
                            label500yen.Text = count[i].ToString();
                            continue;
                        case 100:
                            label100yen.Text = count[i].ToString();
                            continue;
                        case 50:
                            label50yen.Text = count[i].ToString();
                            continue;
                        case 10:
                            label10yen.Text = count[i].ToString();
                            continue;
                        case 5:
                            label5yen.Text = count[i].ToString();
                            continue;
                        case 1:
                            label1yen.Text = count[i].ToString();
                            continue;
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5000yen.Text = "0";
            label1000yen.Text = "0";
            label500yen.Text = "0";
            label100yen.Text = "0";
            label50yen.Text = "0";
            label10yen.Text = "0";
            label5yen.Text = "0";
            label1yen.Text = "0";
        }
    }
}
