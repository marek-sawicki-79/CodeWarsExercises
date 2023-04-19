namespace SumMixedArray
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(22, Kata.SumMix(new object[] { 9, 3, "7", "3" }));
            Assert.AreEqual(42, Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            Assert.AreEqual(41, Kata.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
        }
    }
}