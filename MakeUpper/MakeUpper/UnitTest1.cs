namespace MakeUpper
{
    [TestFixture]
    public class MakeUpperCaseTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("HELLO", Kata.MakeUpperCase("hello"));
        }
    }
}
