namespace IsDivisibleByXAndY
{
    [TestFixture]
    public class DivisibleNbTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, DivisibleNb.IsDivisible(12, 4, 3), "n = 12, x = 3, y = 4");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, DivisibleNb.IsDivisible(3, 3, 4), "n = 3, x = 3, y = 4");
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, DivisibleNb.IsDivisible(8, 3, 4), "n = 8, x = 3, y = 4");
        }
    }
}