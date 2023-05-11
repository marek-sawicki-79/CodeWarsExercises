namespace BuldASqare
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("", Kata.GenerateShape(0));
            Assert.AreEqual("+", Kata.GenerateShape(1));
            Assert.AreEqual("++\n++", Kata.GenerateShape(2));
            Assert.AreEqual("+++\n+++\n+++", Kata.GenerateShape(3));
        }
    }
}