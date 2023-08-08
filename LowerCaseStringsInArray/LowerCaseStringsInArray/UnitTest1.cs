namespace LowerCaseStringsInArray
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new object[] { "red", "green" }, Kata.ArrayLowerCase(new object[] { "Red", "Green" }));
        }
    }
}