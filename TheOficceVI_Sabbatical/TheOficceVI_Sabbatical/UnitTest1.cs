namespace TheOficceVI_Sabbatical
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Sabbatical! Boom!", Kata.Sabb("Can I have a sabbatical?", 5, 5));
            Assert.AreEqual("Back to your desk, boy.", Kata.Sabb("Why are you shouting?", 7, 2));
            Assert.AreEqual("Sabbatical! Boom!", Kata.Sabb("What do you mean I cant learn to code??", 8, 9));
            Assert.AreEqual("Back to your desk, boy.", Kata.Sabb("Please calm down", 9, 1));
        }
    }
}