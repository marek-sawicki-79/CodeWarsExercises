namespace IfElseTernaryPractice
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(100, Kata.SaleHotDogs(1));
            Assert.AreEqual(400, Kata.SaleHotDogs(4));
            Assert.AreEqual(475, Kata.SaleHotDogs(5));
            Assert.AreEqual(855, Kata.SaleHotDogs(9));
            Assert.AreEqual(900, Kata.SaleHotDogs(10));
            Assert.AreEqual(9000, Kata.SaleHotDogs(100));
        }
    }
}