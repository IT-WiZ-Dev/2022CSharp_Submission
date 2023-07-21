using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(yearTextBox.Text);
            int month = (int)monthNumericUpDown.Value;
            int day = (int)dayNumericUpDown.Value;

            // DateTimeオブジェクトを作成して曜日を取得
            DateTime date = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = date.DayOfWeek;

            // 曜日をラベルに表示
            resultLabel.Text = dayOfWeek.ToString();
        }
    

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthNumericUpDown.Minimum = 1;
            monthNumericUpDown.Maximum = 12;

            // 日のニューメリックアップダウンの範囲を設定
            dayNumericUpDown.Minimum = 1;
            dayNumericUpDown.Maximum = 31;
        }
    }
}
