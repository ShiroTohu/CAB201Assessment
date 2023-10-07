using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;

namespace Obstacles;
class Guard : Obstacle
{
    public const char Marker = 'g';
    // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
    private static NodeFactory _nodeFactory = new NodeFactory(Marker);
    protected override Coordinate Origin { get; }
    protected override NodeFactory NodeFactory { get => _nodeFactory; }
    
    public Guard()
    {
        Origin = new Coordinate("Enter the guard's location (X,Y):");
    }

    public Guard(int x, int y)
    {
        Origin = new Coordinate(x, y);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="charMap"></param>
    /// <returns></returns>
    public override Node HasVision(Coordinate coordinate) // doo doo coupling.
    {
        if (coordinate.Position == Origin.Position)
        {
            return NodeFactory.CreateNode(coordinate);
        } 
        else
        {
            throw new Exception();
        }
    }
}