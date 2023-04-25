namespace NativeWelcome
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Welcome", Kata.Greet("english"));
            Assert.AreEqual("Welkom", Kata.Greet("dutch"));
            Assert.AreEqual("Welcome", Kata.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Kata.Greet(""));
            Assert.AreEqual("Welcome", Kata.Greet("2"));
        }
    }
}