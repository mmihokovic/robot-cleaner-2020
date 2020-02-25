using System;
using System.Collections.Generic;
using System.Text;

namespace RobotCleaner
{
    /// <summary>
    /// Class for describing the one location in robot space
    /// </summary>
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            var location = obj as Point;
            return location != null &&
                   X == location.X &&
                   Y == location.Y;
        }

        public override int GetHashCode()
        {
            var hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Returns hard copy of a point
        /// </summary>
        /// <returns>Hard copy of a point</returns>
        public Point GetCopy()
        {
            return new Point(X, Y);
        }
    }
}
