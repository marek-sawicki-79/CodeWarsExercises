namespace DoArithmeticFromStringCommand
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(3, Kata.Arithmetic(1, 2, "add"));
            Assert.AreEqual(6, Kata.Arithmetic(8, 2, "subtract"));
            Assert.AreEqual(10, Kata.Arithmetic(5, 2, "multiply"));
            Assert.AreEqual(4, Kata.Arithmetic(8, 2, "divide"));
        }
    }
}