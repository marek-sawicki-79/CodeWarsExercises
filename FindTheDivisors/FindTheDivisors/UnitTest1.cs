namespace FindTheDivisors
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Kata.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata.Divisors(24));
        }
    }
}