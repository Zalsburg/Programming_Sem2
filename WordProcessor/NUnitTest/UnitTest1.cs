using NUnit.Framework;
using WordProcessor;

namespace Tests {
    public class Tests {

        [SetUp]
        public void Setup() {
        }

        [TestCase("Armaggedon", "ArMaGgEdOn")]
        [TestCase("hillbilly", "hIlLbIlLy")]
        public void AlternateCaseTest(string input, string result) {
            Assert.AreEqual(result, new WordProcessorClass(input).AlternateCase(input));
        }

        [TestCase("Armaggedon", 5, "Fwrflljits")]
        [TestCase("hillbilly", 24, "fgjjzgjjw")]
        [TestCase("OOgIeBOoGY", 10, "YYqSoLYyQI")]
        public void ShiftWordTest(string input, int shiftAmt, string result) {
            Assert.AreEqual(result, new WordProcessorClass(input).ShiftWord(input, shiftAmt));
        }

        [TestCase("Armaggedon", "g")]
        [TestCase("hillbilly", "l")]
        [TestCase("bookkeeper", "o")]
        public void MostCommonLetterTest(string input, char result) {
            Assert.AreEqual(result, new WordProcessorClass(input).MostCommonLetter(input));
        }
    }
}