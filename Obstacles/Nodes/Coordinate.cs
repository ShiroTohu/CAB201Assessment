﻿using System.Xml.Schema;
using Util;

namespace CAB201_Assignment.Obstacles.Nodes
{
    interface ICoordinate
    {
        int X { get; }
        int Y { get; }
        public int[] Position { get; }
        public int GetAxis(char axis);
    }

    /// <summary>
    /// Coordinates is not a physical point on a map. Instead it is an imaginary point.
    /// </summary>
    public class Coordinate : IEquatable<Coordinate>
    {
        public int X { get; }
        public int Y { get; }
        public int[] Position { get => new int[] { X, Y }; }

        /// <summary>
        /// Node Constructor where the x and y coordinates are specified by the parameters.
        /// </summary>
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate(int[] postion)
        {
            X = postion[0];
            Y = postion[1];
        }

        /// <summary>
        /// Node Constructor where the x and y coordinates are specified by the user input.
        /// /// </summary>
        public Coordinate(string prompt)
        {
            int[] postion = Input.PromptCoordinateArray(prompt);

            X = postion[0];
            Y = postion[1];
        }

        public bool Equals(Coordinate? otherCoordinate)
        {
            if (otherCoordinate == null)
            {
                return false;
            }

            return (Position == otherCoordinate.Position);
        }

        public override bool Equals(Object? obj)
        {
            return this.Equals(obj as Coordinate);
        }

        public override int GetHashCode()
        {
            return this.Position.GetHashCode();
        }

        public int GetAxis(char axis)
        {
            switch (axis)
            {
                case 'x':
                    return this.X;
                case 'y':
                    return this.Y;
                default:
                    throw new Exception("Axis not found.");
            }
        }

        public static int GetMinAxis(int axis1, int axis2)
        {
            return axis1 < axis2 ? axis1 : axis2;
        }

        public static int GetMaxAxis(int axis1, int axis2)
        {
            return axis1 > axis2 ? axis1 : axis2;
        }

        public bool IsBetween(Coordinate coordinate1, Coordinate coordinate2)
        {
            int xMax = GetMaxAxis(coordinate1.X, coordinate2.X);
            int xMin = GetMinAxis(coordinate1.X, coordinate2.X);
            int yMax = GetMaxAxis(coordinate1.Y, coordinate2.Y);
            int yMin = GetMinAxis(coordinate1.Y, coordinate2.Y);
            return (X >= xMin && X <= xMax) && (Y >= yMin && Y <= yMax);
        }
    }
}
