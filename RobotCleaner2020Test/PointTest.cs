using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;

namespace RobotCleaner2020Test
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void GetCopyTest()
        {
            const int x = 11;
            const int y = 12;
            var point = new Point(x, y);
            var pointCopy = point.GetCopy();

            Assert.IsFalse(ReferenceEquals(point, pointCopy));
            Assert.AreEqual(point.X, pointCopy.X);
            Assert.AreEqual(point.Y, pointCopy.Y);
            Assert.AreEqual(point, pointCopy);
        }
    }
}
