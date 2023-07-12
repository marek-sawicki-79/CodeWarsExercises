namespace LargestSquareInACircle
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void AreaLargestSquareTest()
        {
            Circle source = new Circle();

            Assert.AreEqual(50, source.AreaLargestSquare(5));
            Assert.AreEqual(98, source.AreaLargestSquare(7));
            Assert.AreEqual(450, source.AreaLargestSquare(15));
        }
    }
}