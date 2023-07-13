namespace OdderThanTheRest
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Your solution should pass basic tests")]
        public void FixedTest()
        {
            Assert.AreEqual(3, Kata.OddOne(new List<int> { 2, 4, 6, 7, 10 }));
            Assert.AreEqual(4, Kata.OddOne(new List<int> { 2, 16, 98, 10, 13, 78 }));
            Assert.AreEqual(4, Kata.OddOne(new List<int> { 4, -8, 98, -12, -7, 90, 100 }));
            Assert.AreEqual(-1, Kata.OddOne(new List<int> { 2, 4, 6, 8 }));
        }
    }
}