namespace HandshakeProblem
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(0, Kata.GetParticipants(0));
            Assert.AreEqual(2, Kata.GetParticipants(1));
            Assert.AreEqual(3, Kata.GetParticipants(3));
            Assert.AreEqual(4, Kata.GetParticipants(6));
            Assert.AreEqual(5, Kata.GetParticipants(7));
        }
    }
}