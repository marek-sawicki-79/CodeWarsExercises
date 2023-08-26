namespace PowersOf4
{
    [TestFixture]
    public class PowerTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(false, Power.PowerOf4(0));
            Assert.AreEqual(true, Power.PowerOf4(4));
            Assert.AreEqual(true, Power.PowerOf4(16));
            Assert.AreEqual(true, Power.PowerOf4(1));
            Assert.AreEqual(false, Power.PowerOf4(3.1415));
            Assert.AreEqual(false, Power.PowerOf4("4"));
            Assert.AreEqual(false, Power.PowerOf4(null));
        }
    }
}
