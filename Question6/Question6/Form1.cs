using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            int num = int.Parse(textBoxChange.Text);
            Moneycalc(num);

        }

        public void Moneycalc(int money)
        {
            int count = 0;
            int[] arr = { 5000, 1000, 500, 100, 50, 10, 5, 1 };
            int[] arr1 = { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int no = 0; money > 0; count++)
            {
                int yen = arr[no];

                if (yen <= money)
                {
                    money = money - yen;
                    arr1[no]++;
                }
                else
                {
                    no++;
                }


            }
            label5000yen.Text = arr1[0].ToString();
            label1000yen.Text = arr1[1].ToString();
            label500yen.Text = arr1[2].ToString();
            label100yen.Text = arr1[3].ToString();
            label50yen.Text = arr1[4].ToString();
            label10yen.Text = arr1[5].ToString();
            label5yen.Text = arr1[6].ToString();
            label1yen.Text = arr1[7].ToString();

        }

        /*
        public void  Moneycalc2(int money)
        {
            int count = 0;
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0};
            while (true)
            {


                if (money >= 5000)
                {

                    money -= 5000;
                    arr[0] = arr[0] + 1;
                    continue;

                }
                else if (money >= 1000)
                {

                    money -= 1000;
                    arr[1] = arr[1] + 1;
                    continue;
                }
                else if (money >= 500)
                {

                    money -= 500;
                    arr[2] = arr[2] + 1;
                    continue;
                }
                else if (money >= 100)
                {
                    money -= 100;
                    arr[3] = arr[3] + 1;
                    continue;
                }
                else if (money >= 50)
                {
                    money -= 50;
                    arr[4] = arr[4] + 1;
                    continue;
                }
                else if (money >= 10)
                {
                    money -= 10;
                    arr[5] = arr[5] + 1;
                    continue;
                }
                else if (money >= 5)
                {
                    money -= 5;
                    arr[6] = arr[6] + 1;
                    continue;
                }
                else if(money >= 1)
                {
                    money -= 1;
                    arr[7] = arr[7] + 1;
                    continue;
                    
                }
                else
                {

                    label5000yen.Text = arr[0].ToString();
                    label1000yen.Text = arr[1].ToString();
                    label500yen.Text = arr[2].ToString();
                    label100yen.Text = arr[3].ToString();
                    label50yen.Text = arr[4].ToString();
                    label10yen.Text = arr[5].ToString();
                    label5yen.Text = arr[6].ToString();
                    label1yen.Text = arr[7].ToString();
                    break;

                }

            }

        }
        */

    }
}
