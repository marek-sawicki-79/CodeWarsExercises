namespace CountDivisors
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1, Kata.Divisors(1));
            Assert.AreEqual(4, Kata.Divisors(10));
            Assert.AreEqual(2, Kata.Divisors(11));
            Assert.AreEqual(8, Kata.Divisors(54));
        }
    }
}