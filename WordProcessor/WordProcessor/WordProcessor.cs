using System;
using System.Linq;
using System.Collections.Generic;

namespace WordProcessor {
    public class WordProcessorClass {
        public string Input;

        public WordProcessorClass(string input) {
            Input = input;
        }

        public string AlternateCase(string input) {
            string output = "";
            string invalidOutput = "";
            List<char> invalidInput = new List<char>();

            for (int i = 0; i < input.Length; i++) {
                if (!((input[i] > 64 && input[i] < 91) || (input[i] > 96 && input[i] < 123))) {
                    invalidInput.Add(input[i]);
                }
            }

            if (invalidInput.Count() > 0) {
                foreach (char c in invalidInput) {
                    invalidOutput += c.ToString() + ", ";
                }
                invalidOutput = invalidOutput.Substring(0, invalidOutput.Length - 2);
                throw new InvalidStringException("These letters are invalid: " + invalidOutput);
            }

            if (char.IsUpper(input[0]) == true) {
                for (int i = 0; i < input.Length; i++) {
                    if (i % 2 == 0) {
                        output += input[i].ToString().ToUpper();
                    }
                    else {
                        output += input[i].ToString().ToLower();
                    }
                }
            }
            else if (char.IsLower(input[0]) == true) {
                for (int i = 0; i < input.Length; i++) {
                    if (i % 2 == 0) {
                        output += input[i].ToString().ToLower();
                    }
                    else {
                        output += input[i].ToString().ToUpper();
                    }
                }
            }
            

            return output;
        }

        public string ShiftWord(string input, int shiftAmt) {
            char[] output = input.ToCharArray();
            string invalidOutput = "";
            List<char> invalidInput = new List<char>();

            for (int i = 0; i < input.Length; i++) {
                if (!((input[i] > 64 && input[i] < 91) || (input[i] > 96 && input[i] < 123))) {
                    invalidInput.Add(input[i]);
                }
            }

            if (invalidInput.Count() > 0) {
                foreach (char c in invalidInput) {
                    invalidOutput += c.ToString() + ", ";
                }
                invalidOutput = invalidOutput.Substring(0, invalidOutput.Length - 2);
                throw new InvalidStringException("These letters are invalid: " + invalidOutput);
            }


            for (int i = 0; i < output.Length; i++) {
                output[i] = (char)(output[i] + shiftAmt);

                if (input[i] > 64 && input[i] < 91) {
                    if (output[i] < 65) {
                        output[i] = (char)(output[i] + 26);
                    }
                    else if (output[i] > 90) {
                        output[i] = (char)(output[i] - 26);
                    }
                }
                else if (input[i] > 96 && input[i] < 123) {
                    if (output[i] < 97) {
                        output[i] = (char)(output[i] + 26);
                    }
                    else if (output[i] > 122) {
                        output[i] = (char)(output[i] - 26);
                    }
                }
            }
            
            return new string(output);
        }

        public char MostCommonLetter(string input) {
            int[] charCount = new int[256];
            int maxCount = -1;
            char output = ' ';
            string invalidOutput = "";
            List<char> invalidInput = new List<char>();

            for (int i = 0; i < input.Length; i++) {
                if (!((input[i] > 64 && input[i] < 91) || (input[i] > 96 && input[i] < 123))) {
                    invalidInput.Add(input[i]);
                }
            }

            if (invalidInput.Count() > 0) {
                foreach (char c in invalidInput) {
                    invalidOutput += c.ToString() + ", ";
                }
                invalidOutput = invalidOutput.Substring(0, invalidOutput.Length - 2);
                throw new InvalidStringException("These letters are invalid: " + invalidOutput);
            }

            //this for loop may not be necessary
            for (int i = 0; i < input.Length; i++) {
                charCount[input[i]]++;
            }

            for (int i = 0; i < input.Length; i++) {
                if (maxCount < charCount[input[i]]) {
                    maxCount = charCount[input[i]];
                    output = input[i];
                }
            }
            
            return output;
        }

        public int AmtOfDifferentChars(string input) {
            int output;
            string invalidOutput = "";
            List<char> invalidInput = new List<char>();

            for (int i = 0; i < input.Length; i++) {
                if (!((input[i] > 64 && input[i] < 91) || (input[i] > 96 && input[i] < 123))) {
                    invalidInput.Add(input[i]);
                }
            }

            if (invalidInput.Count() > 0) {
                foreach (char c in invalidInput) {
                    invalidOutput += c.ToString() + ", ";
                }
                invalidOutput = invalidOutput.Substring(0, invalidOutput.Length - 2);
                throw new InvalidStringException("These letters are invalid: " + invalidOutput);
            }

            output = input.Distinct().Count();

            return output;
        }
    }
}
