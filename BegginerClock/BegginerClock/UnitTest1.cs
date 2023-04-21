namespace BegginerClock
{
    [TestFixture]
    public class ClockTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, Clock.Past(0, 1, 1));
        }
    }
}