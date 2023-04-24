namespace MessiGoalFunction
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void NoGoals()
        {
            Assert.AreEqual(Kata.GetGoals(0, 0, 0), 0);
        }
        [Test]
        public void FiftyEightGoals()
        {
            Assert.AreEqual(Kata.GetGoals(43, 10, 5), 58);
        }
    }
}