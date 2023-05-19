namespace EvensAndOdds
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("10", Kata.EvensAndOdds(2));
            Assert.AreEqual("d", Kata.EvensAndOdds(13));
            Assert.AreEqual("2f", Kata.EvensAndOdds(47));
            Assert.AreEqual("0", Kata.EvensAndOdds(0));
            Assert.AreEqual("11001000000000", Kata.EvensAndOdds(12800));
        }
    }
}