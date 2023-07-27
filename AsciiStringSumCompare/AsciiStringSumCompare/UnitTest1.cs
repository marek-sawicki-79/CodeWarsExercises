namespace AsciiStringSumCompare
{
    [TestFixture]
    public class ComparingTests
    {
        [Test]
        public void Compare1()
        {
            Assert.AreEqual(true, Kata.Compare("AD", "BC"));
        }

        [Test]
        public void Compare2()
        {
            Assert.AreEqual(false, Kata.Compare("AD", "DD"));
        }
    }
}