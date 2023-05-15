namespace LeapYears
{
    [TestFixture]
    public static class LeapYear
    {
        [Test]
        public static void Year1234()
        {
            Assert.AreEqual(false, Kata.IsLeapYear(1234), "Year 1234");
        }

        [Test]
        public static void Year1984()
        {
            Assert.AreEqual(true, Kata.IsLeapYear(1984), "Year 1984");
        }

        [Test]
        public static void Year2000()
        {
            Assert.AreEqual(true, Kata.IsLeapYear(2000), "Year 2000");
        }

        [Test]
        public static void Year2010()
        {
            Assert.AreEqual(false, Kata.IsLeapYear(2010), "Year 2010");
        }

        [Test]
        public static void Year2013()
        {
            Assert.AreEqual(false, Kata.IsLeapYear(2013), "Year 2013");
        }
    }
}