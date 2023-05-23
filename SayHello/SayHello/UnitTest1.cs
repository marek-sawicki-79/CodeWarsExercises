namespace SayHello
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(Greetings.greet("Niks"), "hello Niks!");
            Assert.AreEqual(Greetings.greet(""), null);
            Assert.AreEqual(Greetings.greet(null), null);
        }
    }
}