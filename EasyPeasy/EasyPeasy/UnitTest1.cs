namespace EasyPeasy
{
    [TestFixture]
    public class GreetTest
    {
        [Test]
        public void ShouldReturnHelloWorld()
        {
            Assert.AreEqual("hello world!", Kata.greet());
        }
    }
}
