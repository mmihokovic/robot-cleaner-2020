using System;
using System.Collections.Generic;
using System.Text;

namespace RobotCleaner
{    
    /// <summary>
    /// Class for describing current robot position
    /// </summary>
    public class RobotPosition
    {
        private Point point;
        public RobotPosition(int x, int y)
        {
            this.point = new Point(x, y);
        }

        /// <summary>
        /// Gets current robot position. Returns tuple (x, y)
        /// </summary>
        /// <returns>Returns tuple (x, y)</returns>
        public Point GetCurrentPosition()
        {
            return point;
        }

        /// <summary>
        /// Moves robot horizonraly for step count. 
        /// </summary>
        /// <param name="step">Positive steps move robot east, negative moves robot west.</param>
        /// <returns>Returns current robot position after movement</returns>
        public Point MoveHorizontaly(int step)
        {
            point.X += step;
            return GetCurrentPosition();
        }

        /// <summary>
        /// Moves tobot verticaly for step count.
        /// </summary>
        /// <param name="step">Positive step moves robot north, negative moves robot south</param>
        /// <returns>Return current robot postion after movement</returns>
        public Point MoveVerticaly(int step)
        {
            point.Y += step;
            return GetCurrentPosition();
        }
    }
}
