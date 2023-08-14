namespace InvisibleCubes
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 0)]
        [TestCase(3, ExpectedResult = 1)]
        [TestCase(5, ExpectedResult = 27)]
        public static double FixedTest(int n)
        {
            return Kata.NotVisibleCubes(n);
        }
    }
}