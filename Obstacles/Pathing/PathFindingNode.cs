using CAB201_Assignment.Obstacles.Nodes;
using System;
using System.Collections.Generic;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public abstract class PathFindingNode : Coordinate 
    {
        public PathFindingNode(Coordinate coordinate) : base(coordinate.X, coordinate.Y) { }

        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public PathFindingNode(int x, int y) : base(x, y) { }
        
        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public PathFindingNode(string prompt) : base(prompt) { }
    }
}
