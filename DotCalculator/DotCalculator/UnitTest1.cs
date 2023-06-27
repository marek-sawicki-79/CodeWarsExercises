namespace DotCalculator
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("....................", Kata.Calculator("..... + ..............."));
            Assert.AreEqual("..", Kata.Calculator("..... - ..."));
            Assert.AreEqual("....", Kata.Calculator("..... - ."));
            Assert.AreEqual("...............", Kata.Calculator("..... * ..."));
            Assert.AreEqual("..........", Kata.Calculator("..... * .."));
            Assert.AreEqual("..", Kata.Calculator("..... // .."));
            Assert.AreEqual(".....", Kata.Calculator("..... // ."));
            Assert.AreEqual("", Kata.Calculator(". // .."));
            Assert.AreEqual("", Kata.Calculator(". - ."));
        }
    }
}