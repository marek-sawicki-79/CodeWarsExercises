namespace TwiceAsOld
{
    [TestFixture]
    public class TwiceAsOldTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(30, TwiceAsOldSolution.TwiceAsOld(30, 0));
            Assert.AreEqual(16, TwiceAsOldSolution.TwiceAsOld(30, 7));
            Assert.AreEqual(15, TwiceAsOldSolution.TwiceAsOld(45, 30));
        }
    }
}