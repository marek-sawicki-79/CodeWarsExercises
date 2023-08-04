namespace NumberPairs
{
    [TestFixture]
    public class ZipIt
    {
        [TestCase]
        public void getLargerNumber()
        {
            int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
            int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
            Assert.AreEqual(Kata.getLargerNumbers(arr1, arr2), new int[] { 23, 64, 53, 17, 88 });
        }
    }
}