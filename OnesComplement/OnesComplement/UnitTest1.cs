namespace OnesComplement
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("1", Kata.OnesComplement("0"));
            Assert.AreEqual("0", Kata.OnesComplement("1"));
            Assert.AreEqual("01", Kata.OnesComplement("10"));
            Assert.AreEqual("10", Kata.OnesComplement("01"));
            Assert.AreEqual("0010", Kata.OnesComplement("1101"));
        }
    }
}