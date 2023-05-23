namespace NthRootOfNumber
{
    [TestFixture]
    public class RootTest
    {
        [Test]
        public static void Test1()
        {
            double actual = Kata.FindRoot(4, 2);
            Assert.AreEqual(2, actual, 1e-9);
        }

        [Test]
        public static void Test2()
        {
            double actual = Kata.FindRoot(8, 3);
            Assert.AreEqual(2, actual, 1e-9);
        }

        [Test]
        public static void Test3()
        {
            double actual = Kata.FindRoot(256, 4);
            Assert.AreEqual(4, actual, 1e-9);
        }

        [Test]
        public static void Test4()
        {
            double actual = Kata.FindRoot(9, 2);
            Assert.AreEqual(3, actual, 1e-9);
        }

        [Test]
        public static void Test5()
        {
            double actual = Kata.FindRoot(6.25, 2);
            Assert.AreEqual(2.5, actual, 1e-9);
        }
    }
}