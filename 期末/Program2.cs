﻿using System;
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

   public class Student
    {
      
        private int studentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }

        }

        private string studentName

        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }

        }
        private string otherInfo

        {
            get
            {
                return otherInfo;
            }
            set
            {
                otherInfo = value;
            }

        }

        static void Main(string[] args)
        {

        }
    }
}
