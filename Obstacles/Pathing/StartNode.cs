using CAB201_Assignment.Obstacles.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public class StartNode : PathFindingNode
    {
        public StartNode(Coordinate coordinate) : base(coordinate.X, coordinate.Y) { }

        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public StartNode(int x, int y) : base(x, y) { }

        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public StartNode(string prompt) : base(prompt) { }
    }
}
