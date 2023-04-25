namespace IsItEven
{
    [TestFixture]
    public class NumberTest
    {
        private Number num;

        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(true, num.IsEven(0));
            Assert.AreEqual(false, num.IsEven(0.5));
            Assert.AreEqual(false, num.IsEven(1));
            Assert.AreEqual(true, num.IsEven(2));
            Assert.AreEqual(true, num.IsEven(-4));
        }
    }
}