using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Student
    {
        private string studentID;
        private int studentName;
        private int otherInfo;

        public string StudentID
        {
            set
            {
                this.studentID = value;
            }

            get
            {
                return this.studentID;
            }
        }

        public int StudentName
        {
            set
            {
                this.studentName = value;
            }

            get
            {
                return this.studentName;
            }
        }

        public int OtherInfo
        {
            set
            {
                this.otherInfo = value;
            }

            get
            {
                return this.otherInfo;
            }
        }
    }
}
