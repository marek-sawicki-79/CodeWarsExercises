namespace DrinkAbout
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(22, ExpectedResult = "drink whisky")]
        public static string FixedTest(int old)
        {
            return Kata.PeopleWithAgeDrink(old);
        }
    }
}