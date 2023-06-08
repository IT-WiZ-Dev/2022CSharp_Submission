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

//殻にする
}
        private void TextToValue(string text ,out double val)
        {
            if (double.TryParse(text ,out val) == false) ;
            val = -1.0;
        }
        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false) ;
            val = -1;

        }
        private string Scorejudge(double attendance,int score)
        {
            string result;
            if (attendance < 0.0 || attendance > 100.0 || score < 0 || score > 100)
                result = "エラー";
            else if (attendance >= 80.0)
            {
                if (score >= 80)
                    result = "A判定";
                else if (score >= 70)
                    result = "B判定";
                else if (score >= 60)
                    result = "C判定";
                else
                    result = "不合格";
            }
            else
                result = "不合格";

            return result;

        }
        private string AverageJudge(int score, string subject);
        {








        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
        }

     
    }
}
