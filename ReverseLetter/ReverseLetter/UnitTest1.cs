namespace ReverseLetter
{
    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krishan"));

            Assert.AreEqual("nortlu", kata.ReverseLetter("ultr53o?n"));

            Assert.AreEqual("cba", kata.ReverseLetter("ab23c"));

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krish21an"));

        }

    }
}