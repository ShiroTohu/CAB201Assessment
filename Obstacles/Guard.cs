using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Utils;

namespace Obstacles;
class Guard : Obstacle
{
    private char _marker = 'x';
    public override char Marker
    {
        get
        {
            return _marker;
        }
    }
    protected override void InitializeObstacle()
    {
        _coordinates = Util.PromptCoordinates("Enter the guard's location (X,Y):");
    }

    public override List<int[]> GetVision(CharMap charMap)
    {
        // Originally it was int[,] but in reality the size of the vision would be unknown.
        // Especially for more complex objects.
        List<int[]> vision = new List<int[]>() {};
        if (charMap.CoordinateInMap(_coordinates))
        {
            vision.Add(_coordinates);
        }
        return vision;
    }
}