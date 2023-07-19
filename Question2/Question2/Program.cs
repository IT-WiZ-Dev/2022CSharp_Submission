using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問2
 * 下記の指示通りクラスを作成しなさい。
 * 
 * クラス名：Student
 * 〇メンバー変数
 * 整数型　　：　studentId
 * 文字列型　：　studentName
 * 文字列型　：　otherInfo
 * 
 * ※各メンバーはプライベートで宣言し、getsetのプロパティを作成すること。
 * 
*/



namespace Question2
{
    class Student
    {
        private int studentID;
        private string studentName;
        private string otherInfo;

        public void GetSet(int studentID)
        {
            this.studentID = studentID;
        }

        public void GetSet(string studentName)
        {
            this.studentName = studentName;
        }

        public void Get(string otherInfo)
        {
            this.otherInfo = otherInfo;
        }

        static void Main(string[] args)
        {
        }
    }
}
