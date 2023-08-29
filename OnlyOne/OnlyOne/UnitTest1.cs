namespace OnlyOne
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, Kata.OnlyOne(true, false));
        }
    }
}