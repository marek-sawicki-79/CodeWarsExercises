namespace BandNameGenerator
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("The Knife", Kata.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", Kata.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", Kata.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", Kata.BandNameGenerator("bed"));
        }
    }
}