using System;
using System.Collections.Generic;
using System.Text;

namespace RobotCleaner
{
    /// <summary>
    /// Class for defining one robot movement instruction. Parses string instruction.
    /// </summary>
    public class RobotInstruction
    {
        public int Steps { get; private set; }
        public CardinalDirection CardinalDirection { get; private set; }

        /// <summary>
        /// Constructor for creating and parsing string instrution.
        /// </summary>
        /// <param name="instruciton"></param>
        public RobotInstruction(string instruciton)
        {
            var direction = instruciton.Split(' ')[0].ToLower();
            switch (direction)
            {
                case "e":
                    CardinalDirection = CardinalDirection.East;
                    break;
                case "w":
                    CardinalDirection = CardinalDirection.West;
                    break;
                case "n":
                    CardinalDirection = CardinalDirection.North;
                    break;
                case "s":
                    CardinalDirection = CardinalDirection.South;
                    break;
            }

            Steps = int.Parse(instruciton.Split(' ')[1]);
        }        
    }
}
