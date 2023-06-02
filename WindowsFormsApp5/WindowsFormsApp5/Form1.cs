using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = " ";
            textBox1.Text = "0";

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 12;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 31;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mo;
            int no;
            int bo;
            int Q = 0;
            int D = 0;
            int w = 0;
            mo = int.Parse(textBox1.Text);
            no = int.Parse(numericUpDown1.Text);
            bo = int.Parse(numericUpDown2.Text);
            int A = mo/4;
            int B = mo % 100;
            
            if ((A==0&B>=1)|(A==0&B==0))
            {
                Q = 1;
            }
            if (mo>=1)
            {
                if (Q == 1 & no == 2)
                {
                    if (bo > 29)
                    {
                        
                    }
                   
                }
                else if (no == 2&bo> 28)
                {
                    D = 1;
                }
               

                if ((no == 4| no == 6 | no == 9 | no == 11) &bo < 31)
                {
                  
                }
                else if (no == 4 | no == 6 | no == 9 | no == 11)
                {
                    
                }
                else
                {
                    
                }
                
                if (D == 0)
                {
                    if (no == 1 | no == 2)
                    {
                        no = no + 12;
                        mo = mo + -1;
                        w = ((5 * mo) / (4 - mo) / (100 + mo) / (400 + (26 * no + 16)) / (10 + bo))% 7;
                    }
                    else
                    {
                        w = ((5 * mo) / (4 - mo) / (100 + mo) / (400 + (26 * no + 16)) / (10 + bo)) % 7;
                    }
                    switch (w)
                    {
                        case '0': 

                            label4.Text = "日曜日です";
                            break;
                        case '1':

                            label4.Text = "月曜日です";
                            break;
                        case '2':

                            label4.Text = "火曜日です";
                            break;
                        case '3':

                            label4.Text = "水曜日です";
                            break;
                        case '4':

                            label4.Text = "木曜日です";
                            break;
                        case '5':

                            label4.Text = "金曜日です";
                            break;
                        case '6':

                            label4.Text = "土曜日です";
                            break;


                    }
                }
                else
                {
                    label4.Text = "あり得ない日付";
                }




            }
            else
            {
                label4.Text = "西暦年エラー";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
