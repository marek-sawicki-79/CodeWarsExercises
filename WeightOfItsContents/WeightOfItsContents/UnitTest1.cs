namespace WeightOfItsContents
{
    [TestFixture]
    public class Solution
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(80, SolutionClass.ContentWeight(120, "2 times larger"));
        }
    }
}