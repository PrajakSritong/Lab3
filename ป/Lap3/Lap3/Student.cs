using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3
{
    internal class Student
    {
        public string Name
        {
            get; set;
        }
        public string Student_id
        {
            get; set;
        }
        public string Birthyear
        {
            get; set;
        }
        public string Hight
        {
            get; set;
        }
        public double Grade
        {
            get; set;
        }
        public string Branch
        {
            get; set;
        }
        public Student(string name, string studentid,string birthyear,string hight,double grade,string branch)
        {
            Name = name;
            Student_id = studentid;
            Birthyear = birthyear;
            Hight = hight;
            Grade = grade;
            Branch = branch;
        }
    }
}
