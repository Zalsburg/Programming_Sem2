using System;
using WordProcessor;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Please input string: ");
                string input = Console.ReadLine();
                WordProcessorClass first = new WordProcessorClass(input);
                Console.WriteLine();
                Console.WriteLine("Alternating case:");
                Console.WriteLine(first.AlternateCase(input));
                Console.ReadKey();
                Console.WriteLine();
                Console.Write("Please input shift amount: ");
                int shiftAmt = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Ceaser Cipher:");
                Console.WriteLine(first.ShiftWord(input, shiftAmt));
                Console.ReadKey();
                Console.WriteLine();
                Console.Write("The most common character is: ");
                Console.WriteLine(first.MostCommonLetter(input));
                Console.ReadKey();
                Console.WriteLine();
                Console.Write("The number of unique characters is: ");
                Console.WriteLine(first.AmtOfDifferentChars(input));
            }
            catch (InvalidStringException e) {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
