using System.Numerics;

namespace PowersOf2
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new BigInteger[] { 1 }, Kata.PowersOfTwo(0));
            Assert.AreEqual(new BigInteger[] { 1, 2 }, Kata.PowersOfTwo(1));
            Assert.AreEqual(new BigInteger[] { 1, 2, 4, 8, 16 }, Kata.PowersOfTwo(4));
        }
    }
}