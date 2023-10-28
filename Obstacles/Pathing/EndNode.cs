using CAB201_Assignment.Obstacles.Nodes;
using Util;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public class EndNode : Node
    {
        public EndNode(Coordinate position, char marker = '.', float weight = 1) : base(position, false, marker, weight)
        {
            End = true;
            Solid = false;
        }

        public EndNode(string prompt, char marker = '.', float weight = 1): base(prompt, false, marker, weight)
        {
            End = true;
            Solid = false;
        }
    }
}
