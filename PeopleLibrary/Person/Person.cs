using System;
using System.Collections.Generic;
using System.Text;

namespace Person {
    public abstract class Person {
        public string FName;
        public string SName;
        public int YearofBirth;

        public Person(string fname, string sname, int yearofbirth) {
            FName = fname;
            SName = sname;
            YearofBirth = yearofbirth;
        }

        //returns a string with FName, SName, YearofBirth and other relevant info/data
        public abstract string GetInfo();

        public int GetAge() {
            return DateTime.Now.Year - YearofBirth;
        }
    }
}
