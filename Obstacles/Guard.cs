using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;

namespace Obstacles;
class Guard : Obstacle
{
    public new const char Marker = 'g';
    // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
    public override Coordinate Origin { get; }
    
    public Guard()
    {
        Origin = new Coordinate("Enter the guard's location (X,Y):");
    }

    protected override bool HasVision(Coordinate coordinate)
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
}