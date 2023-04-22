namespace FindMinAndMax
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(-110, new Kata().Min(new[] { -52, 56, 30, 29, -54, 0, -110 }));
            Assert.AreEqual(0, new Kata().Min(new[] { 42, 54, 65, 87, 0 }));
            Assert.AreEqual(566, new Kata().Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
            Assert.AreEqual(5, new Kata().Max(new[] { 5 }));
        }
    }
}