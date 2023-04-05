using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializationDeemo
{
    [Serializable]
    public class Student
    {
        public int rollno;
        public string name;
        public int percentage;

        public Student(int rollno, string name, int percentage)
        {
            this.rollno = rollno;
            this.name = name;
            this.percentage = percentage;
        }
    }
}
