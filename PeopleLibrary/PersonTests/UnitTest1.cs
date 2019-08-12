using NUnit.Framework;
using Person;

namespace Tests {

    [TestFixture]
    public class PersonTests {

        Student s1;
        Student s2;

        //sqaure bracket things are "tags" - they specify what the method below it does
        [SetUp]
        public void Setup() {
            s1 = new Student("Betty", "Boop", 1965, "Web Design");
            s2 = new Student("Bob", "Ross", 1950, "Painting (Landscape)");
        }

        [Test]
        public void GetAgeTest() {
            int expected = 54;
            Assert.AreEqual(expected, s1.GetAge());

            expected = 69;
            Assert.AreEqual(expected, s2.GetAge());
        }
    }
}