namespace EvensXLast
{
	[TestFixture]
	public class SolutionTest
	{
		[Test]
		public void EmptyArrayTest()
		{
			Assert.AreEqual(0, Solver.EvenTimesLast(Array.Empty<int>()));
		}

		[Test]
		public void ArrayWithOneElementTest()
		{
			Assert.AreEqual(49, Solver.EvenTimesLast(new[] { 7 }));
		}

		[Test]
		public void ArrayWithTwoElementsTest()
		{
			Assert.AreEqual(91, Solver.EvenTimesLast(new[] { 7, 13 }));
		}

		[Test]
		public void MyTest()
		{
			Assert.AreEqual(30, Solver.EvenTimesLast(new int[] { 2, 3, 4, 5 }));
			Assert.AreEqual(0, Solver.EvenTimesLast(new int[] { 2, 3, 4, 5, 0 }));
			Assert.AreEqual(-6, Solver.EvenTimesLast(new int[] { 2, 3, 4, -1 }));
		}
	}
}