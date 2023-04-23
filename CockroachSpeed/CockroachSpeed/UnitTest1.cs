namespace CockroachSpeed
{
    [TestFixture]
    public class CockTest1
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(30, Cockroach.CockroachSpeed(1.08));
            Assert.AreEqual(30, Cockroach.CockroachSpeed(1.09));
            Assert.AreEqual(0, Cockroach.CockroachSpeed(0));
        }

    }
}