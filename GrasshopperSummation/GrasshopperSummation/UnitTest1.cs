namespace GrasshopperSummation
{
    [TestFixture]
    public static class KataTests
    {
        [Test]
        public static void BasicTests()
        {
            Assert.AreEqual(1, Kata.summation(1));
            Assert.AreEqual(36, Kata.summation(8));
            Assert.AreEqual(253, Kata.summation(22));
            Assert.AreEqual(5050, Kata.summation(100));
            Assert.AreEqual(22791, Kata.summation(213));
        }
    }
}
