using CAB201_Assignment.Obstacles.Nodes;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public class StartNode : Node
    {
        public StartNode(Coordinate position, bool solid, char marker = '.', float weight = 1) : base(position, solid, marker, weight) 
        {
             = true;
        }
    }
}
