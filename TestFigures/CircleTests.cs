using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib.Figures;


namespace FiguresLib.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Circle_5_return_78p50()
        {
            double radius = 5;

            double expected = 78.54;

            Circle circle = new Circle(radius);
            double actual = circle.Square();

            Assert.AreEqual(expected, actual);
        } 
        
       [TestMethod()]
        public void Circle_m5_return_fail()
        {
            double radius = -55;

            Circle circle = new Circle(radius);


            Assert.IsNull(circle);
        }     

       [TestMethod()]
        public void Circle_0_return_fail()
        {
            double radius = 0;

            Circle circle = new Circle(radius);


            Assert.IsNull(circle);
        }

        [TestMethod()]
        public void CircleTest_Fail()
        {
            Assert.Fail();
        }
    }
}