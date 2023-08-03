namespace WhatsMyGolfScore
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Should calculate sample inputs")]
        public void SampleTest()
        {
            Assert.That(Kata.GolfScoreCalculator("453454444344544443", "354445334534445348"), Is.EqualTo(3));
            Assert.That(Kata.GolfScoreCalculator("333333333333333333", "444444444444444444"), Is.EqualTo(18));
        }
    }
}