using Microsoft.VisualStudio.TestTools.UnitTesting;

using SmallThings.Shapes;



namespace SmallThingsTest
{
    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void TestUmfang()
        {
            Rectangle r = new Rectangle(0, 0, 40, 30);

            Assert.AreEqual((uint) ( 40 + 40 + 30 + 30 ), r.GetUmfang());
        }


        [TestMethod]
        public void TestFlaeche()
        {
            Rectangle r = new Rectangle(0, 0, 40, 30);

            Assert.AreEqual((uint) 1200, r.GetFlaeche());
        }
    }
}
