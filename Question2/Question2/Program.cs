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
        public class Student
        {
            private int studentId = 0221;
            public int Id
            {
                get
                {
                    return studentId;
                }
                set
                {
                    Id = value;
                }
            }
            private string studentName = "眞城博文";
            public string Name
            {
                get
                {
                    return studentName;
                }
                set
                {
                    Name = value;
                }
            }
            public string otherInfo = "なし";
            public string Info
            {
                get
                {
                    return otherInfo;
                }
                set
                {
                    Info = value;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
