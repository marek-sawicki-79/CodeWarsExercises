namespace DiagonalSum
{
    [TestFixture]
    public class DiagonalSumTests
    {

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(12, Kata.DiagonalSum(new int[,] { { 12 } }));
            Assert.AreEqual(5, Kata.DiagonalSum(new int[2, 2] { { 1, 2 }, { 3, 4 } }));
            Assert.AreEqual(15, Kata.DiagonalSum(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }));
            Assert.AreEqual(34, Kata.DiagonalSum(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }));
        }
    }
}