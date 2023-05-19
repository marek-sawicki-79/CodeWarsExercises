namespace FindLuckyNumbers
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual(new int[] { 7, 70, 17 }, Kata.FilterLucky(new int[] { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }));
            Assert.AreEqual(new int[] { }, Kata.FilterLucky(new int[] { }));
        }
    }
}