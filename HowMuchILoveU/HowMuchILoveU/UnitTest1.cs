namespace HowMuchILoveU
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("I love you", Kata.HowMuchILoveYou(7));
            Assert.AreEqual("a lot", Kata.HowMuchILoveYou(3));
            Assert.AreEqual("not at all", Kata.HowMuchILoveYou(6));
        }
    }
}