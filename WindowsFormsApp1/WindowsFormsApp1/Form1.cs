using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Console.Write(TextBox);

            string strYear = Console.ReadLine();
            int intYear = int.Parse(strYear);

            if ((intYear % 4 == 0) && (intYear % 100 != 0) || (intYear % 400 == 0))
            {
                Console.WriteLine();

            }
            else 
            {
                Console.WriteLine();
            }
        
            private string Check(int month,int day)
            {
                string result;

                if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
                    result = 
            }

        
        }
          
         





            

         }

    }

