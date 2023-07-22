namespace LastDigitsOfANumber
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { 1 }, Kata.LastDigit(1, 1));
            Assert.AreEqual(new[] { 3, 7, 6, 7 }, Kata.LastDigit(123767, 4));
            Assert.AreEqual(new[] { 0 }, Kata.LastDigit(0, 1));
            Assert.AreEqual(new[] { 5, 6, 4, 7, 8, 6, 7, 5, 8, 5 }, Kata.LastDigit(34625647867585, 10));
            Assert.AreEqual(new int[] { }, Kata.LastDigit(1234, 0));
            Assert.AreEqual(new int[] { }, Kata.LastDigit(24134, -4));
            Assert.AreEqual(new[] { 1, 3, 4, 3 }, Kata.LastDigit(1343, 5));
        }
    }
}