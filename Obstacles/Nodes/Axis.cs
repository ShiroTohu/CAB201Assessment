using System;

namespace CAB201_Assignment.Obstacles.Nodes
{
    public class Axis
    { 
        public static int GetMinAxis(int axis1, int axis2)
        {
            return axis1 < axis2 ? axis1 : axis2;
        }

        public static int GetMaxAxis(int axis1, int axis2)
        {
            return axis1 > axis2 ? axis1 : axis2;
        }

        public static bool IsBetweenRange(int value, int min, int max)
        {
            return value < min && value > max;
        }
    }
}
