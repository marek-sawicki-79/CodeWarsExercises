namespace ReturnStrings
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }
}
