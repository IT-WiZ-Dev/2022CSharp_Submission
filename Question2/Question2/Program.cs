using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    class Program
    {
        static void Main(string[] args)
        {


        }


        class Student
        {

            private int studentId;
            private string studentName;
            private string otherInfo;

        }

        public int studentId
        {
            get { return studentId; }
            set { studentId = value; }

        }

        public int studentName
        {
            get { return studentId; }
            set { studentId = value; }

        }

        public int otherInfo
        {
            get { return studentId; }
            set { studentId = value; }

        }

        //public int studentId    {get; private set;}

        //public int studentName { get; private set; }

        //public int otherInfo { get; private set; }

    }
}
