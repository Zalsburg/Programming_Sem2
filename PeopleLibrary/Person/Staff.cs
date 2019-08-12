using System;
using System.Collections.Generic;
using System.Text;

namespace Person {
    public class Staff : Person {
        public int Id;

        public Staff(string fname, string sname, int yearofbirth, int id) : base(fname, sname, yearofbirth) {
            Id = id;
        }

        public override string GetInfo() {
            return $"{FName} {SName} {YearofBirth} {Id}";
        }
    }
}
