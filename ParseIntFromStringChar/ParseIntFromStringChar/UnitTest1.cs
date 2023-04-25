namespace ParseIntFromStringChar
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, Kata.GetAge("3 years old"));
            Assert.AreEqual(4, Kata.GetAge("4 years old"));
            Assert.AreEqual(9, Kata.GetAge("9 years old"));
        }
    }
}