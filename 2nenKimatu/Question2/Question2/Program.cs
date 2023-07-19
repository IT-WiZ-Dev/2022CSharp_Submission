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
    class Program
    {
        static void Main(string[] args)
        {

            Student a = new Student();
            a.StudentName = "佐藤圭悟";
            Console.WriteLine(a.StudentName);

        }

        class Student
        {
            private int studentId;
            public int StudentId
            {
                get { return studentId; }
                set { studentId = 123; }
            }

            private string sutudentName;
            public string StudentName
            {
                get { return StudentName; }
                set { sutudentName = value; }
            }

            private string otherInfo;
            public string OtherInfo
            {
                get { return OtherInfo; }
                set { OtherInfo = value; }
            }

        

    
}
}
