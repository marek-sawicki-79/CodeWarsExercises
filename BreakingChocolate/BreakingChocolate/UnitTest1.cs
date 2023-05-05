namespace BreakingChocolate
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(24, Kata.BreakChocolate(5, 5));
            Assert.AreEqual(0, Kata.BreakChocolate(1, 1));
        }
    }
}