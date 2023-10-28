using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;

namespace Obstacles;
public class Guard : Obstacle
{
    public new const bool IsIgnored = false;
    public new const char Marker = 'g';
    // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
    public override Coordinate Origin { get; }
    
    public Guard() : base(Marker)
    {
        Origin = new Coordinate("Enter the guard's location (X,Y):");
    }

    public override bool HasVision(Coordinate coordinate)
    {
        if (coordinate == Origin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override Bounds GetBounds()
    {
        return new Bounds(Origin, Origin);
    }

    public override List<Node> GetNodes(Bounds bounds)
    {
        List<Node> nodes = new List<Node>();
        if (Origin.IsBetween(bounds))
        {
            Node origin = CreateNode(Origin);
            nodes.Add(origin);
        }
        return nodes;
    }
}