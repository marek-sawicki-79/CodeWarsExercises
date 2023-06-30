namespace UniqueSum
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(6, Kata.UniqueSum(new List<int>() { 1, 2, 3 }));
            Assert.AreEqual(12, Kata.UniqueSum(new List<int>() { 1, 3, 8, 1, 8 }));
            Assert.AreEqual(-1, Kata.UniqueSum(new List<int>() { -1, -1, 5, 2, -7 }));
        }
    }
}