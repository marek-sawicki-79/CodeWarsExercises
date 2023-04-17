namespace DNA_ToRNA_Conversion
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void test()
        {
            Converter converter = new Converter();
            Assert.AreEqual("UUUU", converter.dnaToRna("TTTT"));
        }
    }
}