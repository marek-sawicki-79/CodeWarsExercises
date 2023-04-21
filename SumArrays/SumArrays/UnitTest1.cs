namespace SumArrays
{
    [TestFixture]
    public class Sample_Test
    {
        private static object[] testCases = new object[]
        {
      new object[] {new double[] {1, 5.2, 4, 0, -1}, 9.2},
      new object[] {new double[] {}, 0},
        };

        [Test, TestCaseSource("testCases")]
        public void Test(double[] array, double expected) => Assert.AreEqual(expected, Kata.SumArray(array));
    }
}