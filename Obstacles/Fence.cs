using CAB201_Assignment.Utils;
using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;

namespace Obstacles;
class Fence : Obstacle {
    public Coordinate End;

    private const char _marker = 'x';
    public override char Marker { get => _marker; }

    protected override void InitializeObstacle()
    {
        Origin = new Coordinate(0, 0);
        End = new Coordinate(0, 0);
    }

    public override List<int[]> GetVision(CharMap charMap)
    {
        // Originally it was int[,] but in reality the size of the vision would be unknown.
        // Especially for more complex objects.
        List<int[]> vision = new List<int[]>() { _coordinates };
        return vision;
    }
}