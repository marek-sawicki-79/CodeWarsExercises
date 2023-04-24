namespace SearchDivisibleByGiven
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, ExpectedResult = new int[] { 2, 4, 6 })]
        public static int[] FixedTest(int[] numbers, int divisor)
        {
            return Kata.DivisibleBy(numbers, divisor);
        }
    }
}