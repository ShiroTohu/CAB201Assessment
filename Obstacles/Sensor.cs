using CAB201_Assignment.Obstacles.Nodes;
using Util;

namespace Obstacles;

public class Sensor : Obstacle
{
    public new const char Marker = 's';
    // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
    public override Coordinate Origin { get; }
    public double Range { get; }

    public Sensor()
    {
        Origin = new Coordinate("Enter the sensor's location (X,Y):");
        Range = Input.PromptDouble("Enter the sensor's range (in klicks):");
    }

    public override bool HasVision(Coordinate coordinate)
    {
        double position = Math.Sqrt(Math.Pow(coordinate.X - Origin.X, 2) + Math.Pow(coordinate.Y - Origin.Y, 2));
        if ( Range >  position )
        {
            return false;
        }
        return true;
    }

    public override List<Node> GetCoverage(Coordinate TopLeft, Coordinate TopRight)
    {
        throw new NotImplementedException();
    }
}