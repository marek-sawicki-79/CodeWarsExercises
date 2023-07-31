namespace YearDifference
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(18, Kata.HowManyYears("1997/10/10", "2015/10/10"));
            Assert.AreEqual(25, Kata.HowManyYears("1990/10/10", "2015/10/10"));
            Assert.AreEqual(25, Kata.HowManyYears("2015/10/10", "1990/10/10"));
            Assert.AreEqual(23, Kata.HowManyYears("1992/10/24", "2015/10/24"));
            Assert.AreEqual(18, Kata.HowManyYears("2018/10/10", "2000/10/10"));
            Assert.AreEqual(0, Kata.HowManyYears("2000/10/10", "2000/10/10"));
        }
    }
}