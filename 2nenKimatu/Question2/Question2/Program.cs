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
           
        }
    }
}
public class Student
{
    private int studentId
    {
        get
        {
            return studentId; // 外部から取得される
        }
        set
        {
            studentId = value; // 外部から設定する
        }
    }
    
    private String studentName
    {
        get
        {
            return studentName; // 外部から取得される
        }
        set
        {
            studentName = value; // 外部から設定する
        }
    }

    private String otherInfo
    {
        get
        {
            return otherInfo; // 外部から取得される
        }
        set
        {
            otherInfo = value; // 外部から設定する
        }
    }
}
