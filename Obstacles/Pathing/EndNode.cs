using CAB201_Assignment.Obstacles.Nodes;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public class EndNode : Node
    {
        public EndNode(Coordinate position, bool solid, char marker = '.', float weight = 1) : base(position, solid, marker, weight)
        {
            end = true;
        }
    }
}
