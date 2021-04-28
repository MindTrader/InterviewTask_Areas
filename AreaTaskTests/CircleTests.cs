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
    public class CircleTests
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-5.414144)]
        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        public void InitCircle_InvalidDataRows_ExceptionExpected(double r)
        {
            Circle circle = new Circle(r);
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(3.3131)]
        [DataRow(0.41414)]
        public void GetAreaTest_DataRows(double r)
        {
            Circle circle = new Circle(r);
            double expectedVal = Math.PI * r * r;


            double actualVal = circle.GetArea();

            Assert.AreEqual(expectedVal, actualVal);
        }
    }
}