using System;

namespace getNames
{
    [TestFixture]
    public class Sample_Test
    {
        private static Person[] testCase = new Person[]
        {
            new Person("Joe", 20),
            new Person("Bill", 30),
            new Person("Kate", 23)
        };

        [Test, Description("Sample Test")]
        public void Test()
        {
            Assert.AreEqual(new string[] { "Joe", "Bill", "Kate" }, Kata.GetNames(testCase));
        }
    }
}