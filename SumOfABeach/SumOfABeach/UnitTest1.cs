namespace SumOfABeach
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, Kata.SumOfABeach("SanD"));
            Assert.AreEqual(1, Kata.SumOfABeach("sunshine"));
            Assert.AreEqual(4, Kata.SumOfABeach("sunsunsunsun"));
            Assert.AreEqual(1, Kata.SumOfABeach("123FISH321"));
        }
    }
}