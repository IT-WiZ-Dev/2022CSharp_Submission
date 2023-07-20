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
        // フィールド
        internal int AlarmHour = 0;       // アラーム時
        internal int AlarmMinute = 0;     // アラーム分

        public Form2()
        {
            InitializeComponent();
        }

        //「設定ダイアログ」ロードのイベントハンドラ
        private void FormSet_Load(object sender, EventArgs e)
        {
            // 現在時分の表示
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
        }

        //「OKボタン」クリックのイベントハンドラ
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // アラーム時刻の設定
            AlarmHour = (int)numericUpDown1.Value;
            AlarmMinute = (int)numericUpDown2.Value;
        }
    }
}
