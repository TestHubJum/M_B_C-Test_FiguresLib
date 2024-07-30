using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib.Figures;


namespace FiguresLib.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void Equilateral_triangle_5_return_10p8()
        {
            double A = 5;
            double B = 5;
            double C = 5;
            double expected = 10.8;

            Triangle triangle = new Triangle(A, B, C);
            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(triangle.IsRightTriangle());

        }
        
        [TestMethod()]
        public void Right_Triangle_13_12_5_return_30()
        {
            double A = 13;
            double B = 12;
            double C = 5;
            double expected = 30;

            Triangle triangle = new Triangle(A, B, C);
            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(triangle.IsRightTriangle());
            
        }

        [TestMethod()]
        public void Triangle_7_3_5_return_6p5()
        {
            double A = 7;
            double B = 3;
            double C = 5;
            double expected = 6.5;

            Triangle triangle = new Triangle(A, B, C);
            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(triangle.IsRightTriangle());

        }

        [TestMethod()]
        public void Triangle_m6_3_5p2_return_fail()
        {
            double A = -6;
            double B = 3;
            double C = 5.2;
            

            Triangle triangle = new Triangle(A, B, C);


            Assert.IsNull(triangle);

        }
        
        [TestMethod()]
        public void Triangle_5_3_0_return_fail()
        {
            double A = 5;
            double B = 3;
            double C = 0;
            

            Triangle triangle = new Triangle(A, B, C);


            Assert.IsNull(triangle);

        }

        [TestMethod()]
        public void TriagleTest_Fail()
        {
            Assert.Fail();
        }
    }
}