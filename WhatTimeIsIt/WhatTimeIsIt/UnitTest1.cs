namespace WhatTimeIsIt
{
    [TestFixture]
    public class TimeServiceTests
    {

        private TimeService _timeService = new TimeService();

        [TestCase("12:00:01AM", "00:00:01")]
        [TestCase("11:46:47PM", "23:46:47")]
        public void TimeService_can_convert_from_12_hour_time_format_to_24_hour_time_format(string input, string expected)
        {
            var result = _timeService.GetMilitaryTimeFromStandardTime(input);
            Assert.AreEqual(result, expected);
        }
    }
}