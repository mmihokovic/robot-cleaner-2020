using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCleaner
{
    /// <summary>
    /// A class for defining the robot cleaner
    /// </summary>
    public class RobotCleaner
    {
        private RobotPosition robotPosition;
        private HashSet<Point> cleanedLocations;
        public RobotCleaner(int x, int y)
        {
            robotPosition = new RobotPosition(x, y);
            cleanedLocations = new HashSet<Point>();
            cleanedLocations.Add(new Point(x, y));
        }

        private void MoveEast(int steps)
        {
            for(var i= 0; i < steps; i++)
            {
                var cleanedLocation = robotPosition.MoveHorizontaly(1);
                cleanedLocations.Add(cleanedLocation.GetCopy()); // create copy to prevent changing values of already cleaned locations
            }
        }

        private void MoveWest(int steps)
        {
            for (var i = 0; i < steps; i++)
            {
                var cleanedLocation = robotPosition.MoveHorizontaly(-1);
                cleanedLocations.Add(cleanedLocation.GetCopy());
            }
        }

        private void MoveSouth(int steps)
        {
            for (var i = 0; i < steps; i++)
            {
                var cleanedLocation = robotPosition.MoveVerticaly(-1);
                cleanedLocations.Add(cleanedLocation.GetCopy());
            }
        }

        private void MoveNorth(int steps)
        {
            for (var i = 0; i < steps; i++)
            {
                var cleanedLocation = robotPosition.MoveVerticaly(1);
                cleanedLocations.Add(cleanedLocation.GetCopy());
            }
        }

        /// <summary>
        /// Executes robot instructions one by one, on every move it cleans current location
        /// </summary>
        /// <param name="instructions">List of instructions for robot movement</param>
        public void ExecuteInstructions(IEnumerable<RobotInstruction> instructions)
        {
            foreach(var i in instructions)
            {
                switch (i.CardinalDirection)
                {
                    case CardinalDirection.East:
                        MoveEast(i.Steps);
                        break;
                    case CardinalDirection.West:
                        MoveWest(i.Steps);
                        break;
                    case CardinalDirection.North:
                        MoveNorth(i.Steps);
                        break;
                    case CardinalDirection.South:
                        MoveSouth(i.Steps);
                        break;                    
                }
            }
        }

        /// <summary>
        /// Gets cleaned locations count
        /// </summary>
        /// <returns>cleaned locations count</returns>
        public int GetCleanedLocationsCount()
        {
            return cleanedLocations.Count;
        }

        /// <summary>
        /// Returns robot current position
        /// </summary>
        /// <returns>Returns Point object decribing robot position in 2D space</returns>
        public Point GetCurrentLocation()
        {
            return robotPosition.GetCurrentPosition();
        }
    }
}
