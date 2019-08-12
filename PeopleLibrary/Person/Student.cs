using System;
using System.Collections.Generic;
using System.Text;

namespace Person {
    public class Student : Person {
        public string Course;

        public Student(string fname, string sname, int yearofbirth, string course) : base(fname,sname, yearofbirth) {
            Course = course;
        }

        public override string GetInfo() {
            return $"{FName} {SName} {YearofBirth} {Course}";
        }
    }
}
