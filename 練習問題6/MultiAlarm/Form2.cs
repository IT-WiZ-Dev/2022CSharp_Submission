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
    public partial class FormSet : Form
    {
        // フィールド
        internal int AlarmHour = 0;       // アラーム時
        internal int AlarmMinute = 0;     // アラーム分

        public FormSet()
        {
            InitializeComponent();
        }

        //「設定ダイアログ」ロードのイベントハンドラ
        private void FormSet_Load(object sender, EventArgs e)
        {
            // 現在時分の表示
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;
        }

        //「OKボタン」クリックのイベントハンドラ
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // アラーム時刻の設定
            AlarmHour = (int)numericUpDownHour.Value;
            AlarmMinute = (int)numericUpDownMinute.Value;
        }
    }
}
