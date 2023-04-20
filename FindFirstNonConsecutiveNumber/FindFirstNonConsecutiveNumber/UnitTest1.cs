namespace FindFirstNonConsecutiveNumber
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(6, Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }

        [Test]
        public void SequentialTest()
        {
            Assert.AreEqual(null, Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4 }));
        }
    }
}