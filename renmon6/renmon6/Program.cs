using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class MainForm : Form
    {
        private List<Alarm> alarms; // アラームのリスト
        private object currentTimeLabel;

        public MainForm()
        {
            InitializeComponent();

            alarms = new List<Alarm>(); // アラームのリストを初期化
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // フォームがロードされた時に現在時刻を表示する
            UpdateCurrentTimeLabel();

            // タイマーを開始して、毎秒ごとに現在時刻を更新する
            Timer timer = new Timer();
            timer.Interval = 1000; // 1秒ごとに更新
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 毎秒ごとに現在時刻を更新する
            UpdateCurrentTimeLabel();

            // アラームのチェック
            CheckAlarms();
        }

        private void UpdateCurrentTimeLabel()
        {
            // 現在時刻をラベルに表示する
            DateTime currentTime = DateTime.Now;
            currentTimeLabel.Text = currentTime.ToString("HH:mm:ss");
        }

        private void CheckAlarms()
        {
            // アラームのチェック
            foreach (Alarm alarm in alarms)
            {
                if (alarm.IsEnabled && alarm.Time.Hour == DateTime.Now.Hour && alarm.Time.Minute == DateTime.Now.Minute && alarm.Time.Second == DateTime.Now.Second)
                {
                    // アラーム時刻になったらメッセージボックスを表示し、チェックボックスをOFFにする
                    MessageBox.Show("Alarm: " + alarm.Time.ToString("HH:mm:ss"));
                    alarm.IsEnabled = false;
                    alarm.Checkbox.Checked = false;
                }
            }
        }

        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            // アラームの設定ボタンがクリックされた時の処理
            Button button = (Button)sender;

            // 設定ダイアログボックスを生成し、アラーム時刻を取得する
            using (SetTimeDialog dialog = new SetTimeDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // アラームのラベルとチェックボックスを作成し、フォームに追加する
                    Label label = new Label();
                    label.Text = dialog.SelectedTime.ToString("HH:mm:ss");
                    label.AutoSize = true;

                    CheckBox checkbox = new CheckBox();
                    checkbox.Checked = true;

                    // アラームオブジェクトを生成し、リストに追加する
                    Alarm alarm = new Alarm(dialog.SelectedTime, label, checkbox);
                    alarms.Add(alarm);

                    // アラームのラベルとチェックボックスをフォームに配置する
                    int index = alarms.IndexOf(alarm);
                    label.Location = new System.Drawing.Point(12, 50 + index * 25);
                    checkbox.Location = new System.Drawing.Point(150, 50 + index * 25);
                    Controls.Add(label);
                    Controls.Add(checkbox);
                }
            }
        }
    }

    public class Alarm
    {
        public DateTime Time { get; set; }
        public Label Label { get; set; }
        public CheckBox Checkbox { get; set; }
        public bool IsEnabled { get; set; }

        public Alarm(DateTime time, Label label, CheckBox checkbox)
        {
            Time = time;
            Label = label;
            Checkbox = checkbox;
            IsEnabled = true;
        }
    }
}

