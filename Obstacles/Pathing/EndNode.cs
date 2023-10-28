using CAB201_Assignment.Obstacles.Nodes;

namespace CAB201_Assignment.Obstacles.Pathing
{
    public class EndNode : PathFindingNode
    {
        public EndNode(Coordinate coordinate) : base(coordinate.X, coordinate.Y) { }

        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public EndNode(int x, int y) : base(x, y) { }

        /// <inheritdoc/>
        /// <param name="marker">The marker to display on the map.</param>
        public EndNode(string prompt) : base(prompt) { }
    }
}
