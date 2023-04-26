namespace WhatIsBetween
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3 }, Kata.Between(0, 3));
            Assert.AreEqual(new int[] { -2, -1, 0, 1, 2 }, Kata.Between(-2, 2));
            Assert.AreEqual(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, Kata.Between(-10, 10));
        }
    }
}