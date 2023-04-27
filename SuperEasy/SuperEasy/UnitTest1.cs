namespace SuperEasy
{
    [TestFixture]
    public class EasyTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Error", Kata.Problem("hello"));
            Assert.AreEqual("56", Kata.Problem("1"));
            Assert.AreEqual("256", Kata.Problem("5"));
            Assert.AreEqual("6", Kata.Problem("0"));
            Assert.AreEqual("66", Kata.Problem("1.2"));
        }
    }
}