namespace BumpsInTheRoad
{
    [TestFixture]
    class Tests
    {
        [TestCase("n", "Woohoo!")]
        [TestCase("__nn_nnnn__n_n___n____nn__nnn", "Woohoo!")]
        [TestCase("nnn_n__n_n___nnnnn___n__nnn__", "Woohoo!")]
        [TestCase("_nnnnnnn_n__n______nn__nn_nnn", "Car Dead")]
        [TestCase("______n___n_", "Woohoo!")]
        public void BasicTests(string input, string expected)
        {
            Assert.That(Kata.Bump(input), Is.EqualTo(expected));
        }
    }
}