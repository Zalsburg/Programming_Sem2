using System;
using Person;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Student s1 = new Student("Bob", "Smith", 1970, "Programming");
            Console.WriteLine(s1.GetInfo());
            Console.ReadKey();
        }
    }
}
