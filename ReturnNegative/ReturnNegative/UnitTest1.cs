namespace ReturnNegative
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, Kata.MakeNegative(42));
        }
    }
}