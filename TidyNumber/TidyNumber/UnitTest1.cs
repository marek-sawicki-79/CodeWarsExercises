namespace TidyNumber
{
    [TestFixture]
    class Tests
    {
        [TestCase(12)]
        [TestCase(2789)]
        [TestCase(2335)]
        public void BasicTestsTrue(int n)
        {
            Assert.IsTrue(Kata.TidyNumber(n));
        }
        [TestCase(102)]
        [TestCase(9672)]
        public void BasicTestsFalse(int n)
        {
            Assert.IsFalse(Kata.TidyNumber(n));
        }
    }
}