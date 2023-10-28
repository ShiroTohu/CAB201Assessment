﻿using CAB201_Assignment.Obstacles.Nodes;

/**
 * pattern
 * x.x
 * .x.
 * x.x
 */

namespace Obstacles
{
    public class MineField : Obstacle
    {
        public new const char Marker = 'b';
        // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
        public override Coordinate Origin { get; }

        public MineField()
        {
            Origin = new Coordinate("Enter the MineField's location (X,Y):");
        }

        public override bool HasVision(Coordinate coordinate)
        {
            if (coordinate == Origin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override List<Node> GetCoverage(Coordinate TopLeft, Coordinate TopRight)
        {
            throw new NotImplementedException();
        }
    }
}
