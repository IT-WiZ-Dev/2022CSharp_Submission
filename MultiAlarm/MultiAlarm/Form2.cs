using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form2 : Form
    {
        internal int alarmHour = 0; //時
        internal int alarmMinute = 0; //分

        public Form2()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            // ダイアログボックスを閉じる前に選択した時刻を取得
            alarmHour = (int)numericUpDown1.Value;
            alarmMinute = (int)numericUpDown2.Value;
        }

        private void FormSet_Load(object sender, EventArgs e)
        {

        }

    }
}