namespace CatAndMouse
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("Escaped!", Kata.CatMouse("C....m"));
            Assert.AreEqual("Caught!", Kata.CatMouse("C..m"));
            Assert.AreEqual("Escaped!", Kata.CatMouse("C.....m"));
        }
    }
}