using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;

namespace RobotCleaner2020Test
{
    [TestClass]
    public class RobotInstructionTest
    {
        [TestMethod]
        public void ParseRobotInstructionEastTest()
        {
            const string line = "E 2";
            var instruciton = new RobotInstruction(line);

            Assert.AreEqual(CardinalDirection.East, instruciton.CardinalDirection);
            Assert.AreEqual(2, instruciton.Steps);
        }

        [TestMethod]
        public void ParseRobotInstructionWestTest()
        {
            const string line = "W 20";
            var instruciton = new RobotInstruction(line);

            Assert.AreEqual(CardinalDirection.West, instruciton.CardinalDirection);
            Assert.AreEqual(20, instruciton.Steps);
        }

        [TestMethod]
        public void ParseRobotInstructionNorthTest()
        {
            const string line = "N 21231320";
            var instruciton = new RobotInstruction(line);

            Assert.AreEqual(CardinalDirection.North, instruciton.CardinalDirection);
            Assert.AreEqual(21231320, instruciton.Steps);
        }

        [TestMethod]
        public void ParseRobotInstructionSouthTest()
        {
            const string line = "S 5";
            var instruciton = new RobotInstruction(line);

            Assert.AreEqual(CardinalDirection.South, instruciton.CardinalDirection);
            Assert.AreEqual(5, instruciton.Steps);
        }
    }
}
