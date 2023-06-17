namespace Greatest_CommonDivisor
{
    [TestFixture]
    public class Sample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(30, 12).Returns(6);
                yield return new TestCaseData(8, 9).Returns(1);
                yield return new TestCaseData(1, 1).Returns(1);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(int a, int b) => Kata.Gcd(a, b);
    }
}