namespace SumWoHiAndLo
{
    [TestFixture]
    public class SumTests
    {
        [Test]
        public void SumPositives()
        {
            Assert.AreEqual(16, Kata.Sum(new[] { 6, 2, 1, 8, 10 }));
        }

    }