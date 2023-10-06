using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;

namespace Obstacles;
class Guard : Obstacle
{
    private static readonly char _marker = 'g';
    // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
    private static NodeFactory _nodeFactory = new NodeFactory(_marker); 
    protected override Coordinate Origin { get; }
    protected override NodeFactory NodeFactory { get => _nodeFactory; }
    public override char Marker { get => _marker; }
    
    public Guard()
    {
        Origin = new Coordinate("Enter the guard's location (X,Y):");
    }

    public override List<Node> GetVision(CharMap charMap) // doo doo coupling.
    {
        // Originally it was int[,] but in reality the size of the vision would be unknown.
        // Especially for more complex objects.
        List<int[]> vision = new List<int[]>() {};
        if (charMap.CoordinateInMap(_coordinates))
        {
            vision.Add(_coordinates);
            Console.WriteLine($"{_coordinates[0]}, {_coordinates[1]}");
        }
        return vision;
    }
}