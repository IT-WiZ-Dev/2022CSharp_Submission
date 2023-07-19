using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class FormSplitCost : Form
    {
        public FormSplitCost()
        {
            InitializeComponent();
        }

    
        private void FormSplitCost_Load(object sender, EventArgs e)
        {
            labelkekka1.Text = "";
            labelkekka2.Text = "";
        }


        private void ButtonSplit_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);   
            int number = int.Parse(textBox2.Text); 
            const double Tax = 0.1;                     
            int addTax;                                 
            int result1, result2;

            // 消費税を加算
            addTax = (int)(money * (1 + Tax));

        
            result1 = addTax / number;
            result2 = addTax % number;


            labelkekka1.Text = result1 + " 円";
            labelkekka2.Text = result2 + " 円";
        }
    }
}
