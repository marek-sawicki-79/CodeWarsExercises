namespace AreaOrPerimeter
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(MathCheck.AreaOrPerimeter(4, 4), 16);
            Assert.AreEqual(MathCheck.AreaOrPerimeter(6, 10), 32);
        }
    }
}