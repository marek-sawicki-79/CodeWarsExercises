namespace MultiplyStringsInArray
{
    [TestFixture]
    public class BasicTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { new string[] { "4", "5" } }).Returns("20");
                yield return new TestCaseData(new[] { new string[] { "2", "-5" } }).Returns("-10");
                yield return new TestCaseData(new[] { new string[] { "9", "0" } }).Returns("0");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string[] arr) =>
          Kata.ArrMultiply(arr);
    }
}