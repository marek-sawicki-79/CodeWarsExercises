namespace CountTheSheep
{
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            int[] friday = new int[] { 1, 2 };
            int[] saturday = new int[] { 3, 4 };
            Assert.AreEqual(5, kata.lostSheep(friday, saturday, 15));
        }

        [TestCase]
        public void BasicTest2()
        {
            Kata kata = new Kata();
            int[] friday = new int[] { 3, 1, 2 };
            int[] saturday = new int[] { 4, 5 };
            Assert.AreEqual(6, kata.lostSheep(friday, saturday, 21));
        }

        [TestCase]
        public void BasicTest3()
        {
            Kata kata = new Kata();
            int[] friday = new int[] { 5, 1, 4 };
            int[] saturday = new int[] { 5, 4 };
            Assert.AreEqual(10, kata.lostSheep(friday, saturday, 29));
        }
    }
}