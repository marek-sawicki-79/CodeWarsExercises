namespace CalculateBMI
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Normal", Kata.Bmi(80, 1.80));
        }
    }
}