using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekofDay
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        public bool uru(int year)
        {
            if (year % 4 != 0)
            {
                // 4で割り切れない場合は閏年ではない
                return false;
            }

            else if (year % 100 != 0)
            {
                // 4で割り切れるが100で割り切れない場合は閏年
                return true;
            }

            else if (year % 400 != 0)
            {
                // 4で割り切れてかつ100でも割り切れるが400で割り切れない場合は閏年ではない
                return false;
            }

            else
            {
                // 4で割り切れてかつ100でも割り切れてかつ400でも割り切れる場合は閏年
                return true;
            }

            



        }
    }
}
