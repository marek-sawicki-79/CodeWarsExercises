namespace PersonalizedMessage
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Hello boss", Kata.Greet("Daniel", "Daniel"));
            Assert.AreEqual("Hello guest", Kata.Greet("Greg", "Daniel"));
        }
    }
}