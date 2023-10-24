using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Diagnostics.Metrics;
using System;
using System.Dynamic;
using System.Text;

namespace Obstacles;
class Fence : Obstacle {

    public new const char Marker = 'g';
    public override Coordinate Origin { get; }
    public Coordinate End { get; }

    public Fence()
    {
        Origin = new Coordinate("Enter the location where the fence starts(X, Y):");
        End = new Coordinate("Enter the location where the fence ends (X,Y):");
        ValidateObstacleOrientation();
    }

    private bool ValidateObstacleOrientation()
    {
        if (Origin.X == End.X || Origin.Y == End.Y)
        {
            return true;
        }
        else
        {
            throw new ObstacleCreationException();
        }
    }

    protected override bool HasVision(Coordinate coordinate)
    {
        List<int[]> VisionCoordinates = GetVisionCoordinates();
        if (VisionCoordinates.Contains(coordinate.Position))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private List<Coordinate> GetVisionCoordinates()
    {
        IEnumerable<int> range = GetRange();
        List<Coordinate> visionCoordinates = new List<Coordinate>();
        foreach ()
    }

    private IEnumerable<int> GetRange()
    {
        byte axis = GetDifferingAxis(); // 0 for x and 1 for y. makes it more readable\
        // you might be able to modularize this better. Remeber the DRY principle.
        int minAxis = Origin.Position[axis] > End.Position[axis] ? Origin.Position[axis] : End.Position[axis];
        int maxAxis = Origin.Position[axis] < End.Position[axis] ? End.Position[axis] : Origin.Position[axis];
        IEnumerable<int> range = Enumerable.Range(minAxis, maxAxis);
    }

    private static byte GetDifferingAxis(Coordinate point1, Coordinate point2)
    {
        if (Origin.Y == End.Y)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    private static byte getCommonAxis()
    {
        if (Origin.Y == End.Y)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}