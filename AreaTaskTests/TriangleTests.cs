using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(-1, -1, -1)]
        [DataRow(-1, 0, 0)]
        [DataRow(0, -1, 0)]
        [DataRow(0, 0, -1)]
        [DataRow(3, 5, 50)]
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        public void InitTriangle_InvalidDataRows_ExceptionExpected(double sideA, double sideB, double sideC)
        {
            Triangle tr = new Triangle(sideA, sideB, sideC);
        }

        [TestMethod()]
        public void GetArea_3and4and5_6returned()
        {
            Triangle tr = new Triangle(3d, 4d, 5d);
            double expectedVal = 6d;


            double actualVal = tr.GetArea();


            Assert.AreEqual(expectedVal, actualVal);
        }

        [DataTestMethod]
        [DataRow(1, 2, 2.9)]
        [DataRow(2, 3, 4)]
        [DataRow(5, 7, 10)]
        [DataRow(3, 5, 6)]
        [DataRow(1.54, 2.4654, 3.1413)]
        [DataRow(500, 413, 766)]
        public void IsRectangular_DataRows_FalseReturned(double sideA, double sideB, double sideC)
        {
            Triangle tr = new Triangle(sideA, sideB, sideC);

            Assert.IsFalse(tr.IsRectangular());
        }

        [TestMethod()]
        public void IsRectangular_3and4and5_TrueReturned()
        {
            Triangle tr = new Triangle(3d, 4d, 5d);

            Assert.IsTrue(tr.IsRectangular());
        }
    }
}