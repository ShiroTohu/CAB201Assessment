using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Nodes
{
    /// <summary>
    /// Node is what is physically on the NodeMap. This means that this can encompas vision etc.
    /// </summary>
    public class Node : Coordinate
    {
        char Marker { get; }

        public Node(Coordinate coordinate, char marker) : base(coordinate.X, coordinate.Y)
        {
            Marker = marker;
        }

        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public Node(int x, int y, char marker) : base(x, y) 
        {
            Marker = marker;
        }
        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public Node(string prompt, char marker) : base(prompt) 
        {
            Marker = marker;
        }
    }
}
