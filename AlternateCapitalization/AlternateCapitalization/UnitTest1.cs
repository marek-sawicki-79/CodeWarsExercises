namespace AlternateCapitalization
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, Kata.Capitalize("abcdef"));
            Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, Kata.Capitalize("codewars"));
            Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, Kata.Capitalize("abracadabra"));
            Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, Kata.Capitalize("codewarriors"));
        }
    }
}