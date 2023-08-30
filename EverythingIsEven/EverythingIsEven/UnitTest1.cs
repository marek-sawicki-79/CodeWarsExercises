namespace EverythingIsEven
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(2, Kata.EnsureEven(1));
            Assert.AreEqual(2, Kata.EnsureEven(1.356));
        }
    }
}