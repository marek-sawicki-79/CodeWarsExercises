namespace WillBeThereEnoughSpace
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, Kata.Enough(10, 5, 5));
            Assert.AreEqual(10, Kata.Enough(100, 60, 50));
            Assert.AreEqual(0, Kata.Enough(20, 5, 5));
        }
    }
}