using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;
using System.Collections.Generic;

namespace RobotCleaner2020Test
{
    [TestClass]
    public class RobotCleanerTest
    {
        [TestMethod]
        public void MoveEastTest()
        {
            var robotCleaner = new RobotCleaner.RobotCleaner(0, 0);
            var robotInstruction = new RobotInstruction("E 20");

            robotCleaner.ExecuteInstructions(new List<RobotInstruction>() { robotInstruction });
            var robotPosition = robotCleaner.GetCurrentLocation();

            Assert.AreEqual(20, robotPosition.X);
            Assert.AreEqual(0, robotPosition.Y);
        }

        [TestMethod]
        public void MoveWestTest()
        {
            var robotCleaner = new RobotCleaner.RobotCleaner(0, 0);
            var robotInstruction = new RobotInstruction("W 5");

            robotCleaner.ExecuteInstructions(new List<RobotInstruction>() { robotInstruction });
            var robotPosition = robotCleaner.GetCurrentLocation();

            Assert.AreEqual(-5, robotPosition.X);
            Assert.AreEqual(0, robotPosition.Y);
        }

        [TestMethod]
        public void MoveSouthTest()
        {
            var robotCleaner = new RobotCleaner.RobotCleaner(0, 0);
            var robotInstruction = new RobotInstruction("S 13");

            robotCleaner.ExecuteInstructions(new List<RobotInstruction>() { robotInstruction });
            var robotPosition = robotCleaner.GetCurrentLocation();

            Assert.AreEqual(0, robotPosition.X);
            Assert.AreEqual(-13, robotPosition.Y);
        }

        [TestMethod]
        public void MoveNorthTest()
        {
            var robotCleaner = new RobotCleaner.RobotCleaner(0, 0);
            var robotInstruction = new RobotInstruction("S 100");

            robotCleaner.ExecuteInstructions(new List<RobotInstruction>() { robotInstruction });
            var robotPosition = robotCleaner.GetCurrentLocation();

            Assert.AreEqual(0, robotPosition.X);
            Assert.AreEqual(-100, robotPosition.Y);
        }

        [TestMethod]
        public void MoveNorthThenReturnTest()
        {
            var robotCleaner = new RobotCleaner.RobotCleaner(0, 0);
            var robotInstructionNorth = new RobotInstruction("N 100");
            var robotInstructionSouth = new RobotInstruction("S 100");

            robotCleaner.ExecuteInstructions(new List<RobotInstruction>() { robotInstructionNorth, robotInstructionSouth });

            Assert.AreEqual(101, robotCleaner.GetCleanedLocationsCount());
        }

        [TestMethod]
        public void MoveWestThenReturnTest()
        {
            var robotCleaner = new RobotCleaner.RobotCleaner(0, 0);
            var robotInstructionWest = new RobotInstruction("W 55");
            var robotInstructionEast = new RobotInstruction("E 55");

            robotCleaner.ExecuteInstructions(new List<RobotInstruction>() { robotInstructionWest, robotInstructionEast });

            Assert.AreEqual(56, robotCleaner.GetCleanedLocationsCount());
        }
    }
}
