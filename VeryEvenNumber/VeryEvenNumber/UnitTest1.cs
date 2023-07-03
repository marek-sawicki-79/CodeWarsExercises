namespace VeryEvenNumber
{
    [TestFixture]
    public class OddLadderTests
    {
        [TestCase(0, true, TestName = "0 is 'Very Even'")]
        [TestCase(4, true, TestName = "4 is 'Very Even'")]
        [TestCase(12, false, TestName = "12 is not 'Very Even'")]
        [TestCase(222, true, TestName = "222 is 'Very Even'")]
        [TestCase(5, false, TestName = "5 is not 'Very Even'")]
        [TestCase(45, false, TestName = "45 is not 'Very Even'")]
        [TestCase(4554, false, TestName = "4554 is not 'Very Even'")]
        [TestCase(1234, false, TestName = "1234 is not 'Very Even'")]
        [TestCase(88, false, TestName = "88 is not 'Very Even'")]
        [TestCase(24, true, TestName = "24 is 'Very Even'")]
        [TestCase(400000220, true, TestName = "400000220 is 'Very Even'")]
        public void Test(int number, bool expected)
        {
            Assert.That(Kata.IsVeryEvenNumber(number), Is.EqualTo(expected));
        }
    }
}