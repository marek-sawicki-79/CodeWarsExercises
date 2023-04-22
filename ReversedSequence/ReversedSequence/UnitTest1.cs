namespace ReversedSequence
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
        }
    }
}