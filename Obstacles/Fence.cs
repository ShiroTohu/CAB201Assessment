using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;

namespace Obstacles;
class Fence : Obstacle {
    public Coordinate End;

    public new const char Marker = 'g';
    private static NodeFactory _nodeFactory = new NodeFactory(Marker);
    protected override Coordinate Origin { get; }
    protected override NodeFactory NodeFactory { get => _nodeFactory; }

    public Fence()
    {
        Origin = new Coordinate(0, 0);
        End = new Coordinate(0, 0);
    }

    public override Node HasVision(Coordinate coordinate)
    {
        
    }
}