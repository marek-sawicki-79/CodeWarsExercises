namespace StudentFinalGrade
{
    [TestFixture]
    public class Testing
    {
        [Test]
        public void FinalGradeTest()
        {
            Assert.AreEqual(100, Kata.FinalGrade(100, 12));
            Assert.AreEqual(90, Kata.FinalGrade(85, 5));
        }
    }
}