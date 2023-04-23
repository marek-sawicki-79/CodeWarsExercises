namespace ThirdAngleOfTriangle
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.OtherAngle(30, 60), Is.EqualTo(90));
            Assert.That(Kata.OtherAngle(60, 60), Is.EqualTo(60));
            Assert.That(Kata.OtherAngle(43, 78), Is.EqualTo(59));
            Assert.That(Kata.OtherAngle(10, 20), Is.EqualTo(150));
        }
    }
}