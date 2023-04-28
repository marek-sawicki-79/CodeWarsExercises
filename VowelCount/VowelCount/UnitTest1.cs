namespace VowelCount
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}