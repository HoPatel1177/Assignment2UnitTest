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
      
        
    }
}
