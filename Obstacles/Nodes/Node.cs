using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Nodes
{
    public class Node : Coordinate
    {
        char Marker { get; }

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
