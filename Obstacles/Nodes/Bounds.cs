using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Obstacles.Nodes
{
    public class Bounds
    {
        public Coordinate TopLeftCoordinate { get; }
        public Coordinate BottomRightCoordinate { get; }
        public Bounds(Coordinate topLeftCoordinate, Coordinate bottomRightCoordinate)
        {
            this.TopLeftCoordinate = bottomRightCoordinate;
            this.BottomRightCoordinate = bottomRightCoordinate;
        }
    }
}
