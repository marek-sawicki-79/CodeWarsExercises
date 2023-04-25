namespace CountChars
{
    [TestFixture]
    class Tets
    {
        [TestCase("Hello", 'o', 1)]
        [TestCase("Hello", 'l', 2)]
        [TestCase("Hello", 'p', 0)]
        [TestCase("", 'z', 0)]
        public void BasicTetst(string str, char letter, int expected)
        {
            Assert.That(Kata.StrCount(str, letter), Is.EqualTo(expected));
        }
    }
}