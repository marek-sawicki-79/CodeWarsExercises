namespace SumOfDiffrencesBetweenProductsAndLcm
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(840, Kata.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 18 }, new int[] { 4, 5 }, new int[] { 12, 60 } }));
            Assert.AreEqual(1092, Kata.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 }, new int[] { 13, 91 } }));
            Assert.AreEqual(0, Kata.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 7 }, new int[] { 4, 5 }, new int[] { 19, 60 } }));
            Assert.AreEqual(1890, Kata.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 20, 50 }, new int[] { 10, 10 }, new int[] { 50, 20 } }));
            Assert.AreEqual(0, Kata.SumDifferencesBetweenProductsAndLCMs(new int[][] { }));
        }
    }
}