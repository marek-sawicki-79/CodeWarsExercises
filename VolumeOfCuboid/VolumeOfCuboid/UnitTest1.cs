namespace VolumeOfCuboid
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(60, Kata.GetVolumeOfCuboid(2, 5, 6), 0.00001, "Length: 2, Width: 5, Height: 6");
            Assert.AreEqual(94.5, Kata.GetVolumeOfCuboid(6.3, 3, 5), 0.00001, "Length: 6.3, Width: 3, Height: 5");
        }
    }
}