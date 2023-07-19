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
            Student INI = new Student();

            INI.StudentId = 22410136;
            INI.StudentName = "鈴木 陽翔";
            INI.OtherInfo = "";

            Console.WriteLine(INI.StudentId);    
            Console.WriteLine(INI.StudentName);     
            Console.WriteLine(INI.OtherInfo);
        }
    }
}
