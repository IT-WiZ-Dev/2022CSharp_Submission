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

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int s = 0;
           
            if(int.TryParse(textBoxChange.Text,out int n) == true)
            {
                s = n / 5000;
                label5000yen.Text = s.ToString();
                n = n % 5000;
                s = n / 1000;
                label1000yen.Text= s.ToString();
                n= n % 1000;
                s = n / 500;
                label500yen.Text= s.ToString();
                n=n% 500;
                s = n/ 100;
                label100yen.Text= s.ToString();
                n = n % 100;
                s= n/ 50;
                label50yen.Text= s.ToString();
                n = n % 50;
                s = n / 10;
                label10yen.Text= s.ToString();
                n = n % 10;
                s = n / 5;
                label5yen.Text=s.ToString();
                n = n % 5;
                s = n;
                label1yen.Text= s.ToString();
            }
            else
            {
                label5000yen.Text = "エラー";
                return;
            }
        }
    }
}
