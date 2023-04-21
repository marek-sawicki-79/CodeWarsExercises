namespace BasicMathematicalOparatios
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(11, Program.basicOp('+', 4, 7));
            Assert.AreEqual(-3, Program.basicOp('-', 15, 18));
            Assert.AreEqual(25, Program.basicOp('*', 5, 5));
            Assert.AreEqual(7, Program.basicOp('/', 49, 7));
        }
    }
}