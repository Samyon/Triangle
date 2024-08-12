using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        int count = 1000000;

        [TestMethod]
        public void TestMethod1_0()
        {
            var result = Triangle.DetermineTriangleType(1, 1, 1);
            Assert.AreEqual(Triangle.TriangleType.AcuteTriangle, result);
        }

        [TestMethod]
        public void TestMethod1_1()
        {
            var result = Triangle.DetermineTriangleType(2, 2, 2);
            Assert.AreEqual(Triangle.TriangleType.AcuteTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_0()
        {
            var result = Triangle2.DetermineTriangleType(2, 2, 2);
            Assert.AreEqual(Triangle2.TriangleType.AcuteTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_1()
        {
            var result = Triangle2.DetermineTriangleType(3, 4, 5);
            Assert.AreEqual(Triangle2.TriangleType.RightTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_2()
        {
            var result = Triangle2.DetermineTriangleType(1, 1, Math.Sqrt(2));
            Assert.AreEqual(Triangle2.TriangleType.RightTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_3()
        {
            var result = Triangle2.DetermineTriangleType(5, 3, Math.Sqrt(34));
            Assert.AreEqual(Triangle2.TriangleType.RightTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_4()
        {
            var result = Triangle2.DetermineTriangleType(3.5, 3, Math.Sqrt(34));
            Assert.AreEqual(Triangle2.TriangleType.DummyTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_5()
        {
            var result = Triangle2.DetermineTriangleType(3, 3, 4);
            Assert.AreEqual(Triangle2.TriangleType.AcuteTriangle, result);
        }

        [TestMethod]
        public void TestMethod2_6()
        {
            var result = Triangle2.DetermineTriangleType(3, 4, 6);
            Assert.AreEqual(Triangle2.TriangleType.DummyTriangle, result);
        }


    }
}
