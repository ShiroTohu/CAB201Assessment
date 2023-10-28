using CAB201_Assignment.Obstacles.Nodes;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public class StartNode : Node
    {
        public StartNode(Coordinate position, char marker = '.', float weight = 1) : base(position, false, marker, weight) 
        {
            Start = true;
        }

        public StartNode(string prompt, char marker = '.', float weight = 1) : base(prompt, false, marker, weight)
        {
            End = true;
            Solid = false;
        }
    }
}
