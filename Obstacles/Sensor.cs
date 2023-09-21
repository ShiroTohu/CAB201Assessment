using CAB201_Assignment.Utils;
using CAB201_Assignment.ObstacleMap;

namespace Obstacles;

class Sensor : Obstacle{
    protected override void InitializeObstacle()
    {
        Util.PromptCoordinates("Balls");
    }

    public override List<int[]> GetVision(CharMap charMap)
    {
        // Originally it was int[,] but in reality the size of the vision would be unknown.
        // Especially for more complex objects.
        List<int[]> vision = new List<int[]>() { _coordinates };
        return vision;
    }
}