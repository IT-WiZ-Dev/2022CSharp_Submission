using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dai7show
{
    public partial class Form2 : Form
    {
        private int _nen;
        private int _tuki;
        private int _sentaku;
        public Form2(int nen ,int tuki,int n)
        {
            InitializeComponent();
            _nen = nen;
            _tuki= tuki;
            _sentaku = n;
           
            int daysInMonth = DateTime.DaysInMonth(_nen, _tuki);
            daysInMonth = daysInMonth - 3;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            int kane;
            int daysInMonth = DateTime.DaysInMonth(_nen, _tuki);
            daysInMonth = daysInMonth - 3;
            DateTime dt=new DateTime(_nen,_tuki,daysInMonth);
            string week = dt.DayOfWeek.ToString();

            if (_sentaku == 0||_sentaku==1||_sentaku==4)
            {
                kane = 1000;
                if (_sentaku == 0)
                {
                    labelzikan.Text = "14 : 00";
                }else if (_sentaku == 1)
                {
                    labelzikan.Text = "10 : 00";
                }
                else
                {
                    labelzikan.Text = "20 : 00";
                }
            }else if (_sentaku==2||_sentaku==3) {
                kane = 800;
                if (_sentaku == 2)
                {
                    labelzikan.Text = "17 : 00";
                }
                else
                {
                    labelzikan.Text = "19 : 00";
                }
                
            }
            else if(_sentaku==5){
                kane = 1200;
                labelzikan.Text = "20 : 00";
            }else if (_sentaku == 6)
            {
                kane = 1500;
                labelzikan.Text = "10 : 00";
            }//1回文の値段と時間入れ
           
    }
    }
}
