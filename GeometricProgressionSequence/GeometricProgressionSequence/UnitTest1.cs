namespace GeometricProgressionSequence
{
    [TestFixture]
    public class GeometricSequenceElementsTest
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("2, 6, 18, 54, 162", Kata.GeometricSequenceElements(2, 3, 5));
            Assert.AreEqual("2, 4, 8, 16, 32, 64, 128, 256, 512, 1024", Kata.GeometricSequenceElements(2, 2, 10));
            Assert.AreEqual("1, -2, 4, -8, 16, -32, 64, -128, 256, -512", Kata.GeometricSequenceElements(1, -2, 10));
        }
    }
}