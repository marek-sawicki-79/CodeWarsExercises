namespace HighestProfitWins_FindMinAndMaxInArray
{
	[TestFixture]
	public class MinMaxTests
	{

		[Test]
		public static void BasicTest()
		{
			Assert.AreEqual(new int[] { -1, 20 }, MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
			Assert.AreEqual(new int[] { 1, 5 }, MinMax.minMax(new int[] { 1, 2, 3, 4, 5 }));
			Assert.AreEqual(new int[] { -3, 5 }, MinMax.minMax(new int[] { 1, 2, -3, 4, 5 }));
		}
	}
}