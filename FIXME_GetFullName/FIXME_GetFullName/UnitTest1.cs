namespace FIXME_GetFullName
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Sample Test")]
        public void SampleTest()
        {
            Assert.AreEqual("Clint Eastwood", new Dinglemouse("Clint", "Eastwood").FullName);
        }
    }
}