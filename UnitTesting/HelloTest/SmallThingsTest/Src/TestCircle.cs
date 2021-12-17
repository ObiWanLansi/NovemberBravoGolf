using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using SmallThings.Shapes;



namespace SmallThingsTest
{
    [TestClass]
    public class TestCircle
    {
        private const uint TEST_RADIUS = 42;


        [TestMethod]
        public void TestRadius()
        {
            Circle c = new Circle(TEST_RADIUS);

            Assert.AreEqual(TEST_RADIUS, c.GetRadius());
        }


        [TestMethod]
        public void TestDurchmesser()
        {
            Circle c = new Circle(TEST_RADIUS);

            Assert.AreEqual(TEST_RADIUS * (uint) 2, c.GetDurchmesser());
        }


        [TestMethod]
        public void TestUmfang()
        {
            Circle c = new Circle(TEST_RADIUS);

            Assert.AreEqual(TEST_RADIUS * 2 * Math.PI, c.GetUmfang());
        }


        [TestMethod]
        public void TestFlaeche()
        {
            Circle c = new Circle(TEST_RADIUS);

            Assert.AreEqual(Math.Pow(TEST_RADIUS, 2) * Math.PI, c.GetFlaeche());
        }
    }
}
