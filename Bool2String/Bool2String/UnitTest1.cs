namespace Bool2String
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("True", kata.BooleanToString(true));
            Assert.AreEqual("False", kata.BooleanToString(false));
        }
    }
}