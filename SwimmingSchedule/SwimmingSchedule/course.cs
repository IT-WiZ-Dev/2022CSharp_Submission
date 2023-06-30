using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class course
    {
        // フィールド（クラス内の変数）
        private string courseName;  // コースの名前
        private int dayOfWeek;      // 曜日（1: 月曜日, 2: 火曜日, ...）
        private int startTime;      // 開始時刻（24時間形式）
        private int price;          // コースの価格

        // コンストラクタ（クラスのインスタンスを初期化する特殊なメソッド）
        public course(string name, int day, int time, int p)
        {
            this.courseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }

        // プロパティ（フィールドへのアクセスを制御するメソッド）
        public string CourseName
        {
            get { return this.courseName; }   // コース名の取得
            set { this.courseName = value; }  // コース名の設定
        }
        public int DayOfWeek
        {
            get { return this.dayOfWeek; }    // 曜日の取得
            set { this.dayOfWeek = value; }   // 曜日の設定
        }
        public int StartTime
        {
            get { return this.startTime; }    // 開始時刻の取得
            set { this.startTime = value; }   // 開始時刻の設定
        }
        public int Price
        {
            get { return this.price; }        // 価格の取得
            set { this.price = value; }       // 価格の設定
        }
    }
}
