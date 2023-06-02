using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void urudoshi(string text,out bool b)
        {
            int a = int.Parse(text); ;

            if (a % 4 == 0 && a != 0)
                b = true;
            else
                b = false;
        }

        private void A(int month, int day,bool b,out bool answer )
        {
            int n;
            if ( b == true)
                n = 1;
            else
                n = 0;

            if (month == 4 || month == 6 || month == 9 || month == 11)
                if (day >= 30)
                    answer = true;
                else
                    answer = false;
            else if (month == 2)
                if (day >= 29 - n)
                    answer = true;
                else
                    answer = false;
            else if (day >= 31)
                answer = true;
            else
                answer = false;
         }

        private void texttovalue(string text,out int val)
        {
            int n = int.Parse(text);
            val = 1;
            if (int.TryParse(text, out val) == false && n <= 0) 
                val = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urudoshi(textBox1.Text,out bool b);
            int nuw1 = (int)numericUpDown1.Value;
            int num2 = (int)numericUpDown2.Value;
            A(nuw1, num2,b,out bool answer);

            texttovalue(textBox1.Text, out int val);
            int n = int.Parse(textBox1.Text);
            int s;

            if (val == -1)
                label4.Text = "";
            else if (answer == false)
                label4.Text = "";
            else
                s =( 5 * n / (4 - n) / 100 + n / 400 + (26 * nuw1 + 16) / (10 + num2)) % 7;


            switch (s)
            {
                case 0:
                    label4.Text = "日曜日";
                    break;


            }
            
            
            
        }
    }
}
