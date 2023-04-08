namespace StringRrepeat
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Assert.AreEqual("***", Program.RepeatStr(3, "*"));
            Assert.AreEqual("#####", Program.RepeatStr(5, "#"));
            Assert.AreEqual("ha ha ", Program.RepeatStr(2, "ha "));
        }
    }
}