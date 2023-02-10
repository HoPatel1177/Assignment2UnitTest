using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Method1_Equilateral_triangle()
        {
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(4, 4, 4);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method2_Isosceles_triangle()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(5, 5, 7);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method3_Isosceles_triangle()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(6, 8, 8);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method4_Isosceles_triangle()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(9, 9, 12);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method5_Scalene_triangle()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(3, 4, 5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method6_Scalene_triangle()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(5, 12, 13);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method7_Scalene_triangle()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(8, 15, 17);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method8_Scalene_triangle()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(6, 7, 9);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method9_Scalene_triangle()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(11, 14, 16);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Method10_Zero_Length()
        {
            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(0, 14, 16);
            Assert.AreEqual(expected, actual);
        }
      
        
    }
}
