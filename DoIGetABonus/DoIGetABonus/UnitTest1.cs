namespace DoIGetABonus
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("$100000", Kata.bonus_time(10000, true));
            StringAssert.AreEqualIgnoringCase("$250000", Kata.bonus_time(25000, true));
            StringAssert.AreEqualIgnoringCase("$10000", Kata.bonus_time(10000, false));
            StringAssert.AreEqualIgnoringCase("$60000", Kata.bonus_time(60000, false));
            StringAssert.AreEqualIgnoringCase("$20", Kata.bonus_time(2, true));
            StringAssert.AreEqualIgnoringCase("$78", Kata.bonus_time(78, false));
            StringAssert.AreEqualIgnoringCase("$678900", Kata.bonus_time(67890, true));
        }
    }
}