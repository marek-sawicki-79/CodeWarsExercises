namespace FailedFilterBugFixing
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("test", Kata.FilterNumbers("test123"));
            Assert.AreEqual("abc", Kata.FilterNumbers("a1b2c3"));
            Assert.AreEqual("aabbccdd", Kata.FilterNumbers("aa1bb2cc3dd"));
        }
    }
}