namespace SpongebobMeme
{
    [TestFixture]
    public class SolutionTest
    {

        private static object[] Basic_Test_Cases = new object[]
        {
      new object[] {"stop Making spongebob Memes!", "StOp mAkInG SpOnGeBoB MeMeS!"},
        };

        [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
        public void Basic_Test(string test, string expected)
        {
            Assert.AreEqual(expected, Kata.SpongeMeme(test));
        }
    }
}