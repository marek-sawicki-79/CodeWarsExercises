namespace StringOfFirstChars
{
    [TestFixture]
    public static class MakeStringTests
    {
        [Test]
        public static void TestExample0()
        {
            Assert.AreEqual("cia",
              Kata.MakeString("coding is awesome"));
        }
    }
}