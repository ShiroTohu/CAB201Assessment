using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Diagnostics.Metrics;
using System;
using System.Dynamic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Obstacles;
public class Fence : Obstacle {
    public new const bool Ignored = false;

    public new const char Marker = 'f';
    public override Coordinate Origin { get; }
    public Coordinate End { get; }
    private char DifferingAxis
    {
        get
        {
            return GetDifferingAxis();
        }
    }
    private char CommonAxis 
    {
        get
        {
            return GetCommonAxis();
        }
    }

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

    public override bool HasVision(Coordinate coordinate)
    {
        switch(DifferingAxis)
        {
            case 'x':
                return IsBetweenRange(coordinate.X, GetMinAxis('x'), GetMaxAxis('x'));
            case 'y':
                return IsBetweenRange(coordinate.X, GetMinAxis('y'), GetMaxAxis('y'));
            default:
                return false;
        }
    }

    private static bool IsBetweenRange(int value, int min, int max)
    {
        return value < min && value > max;
    }

    public override List<Node> GetCoverage(Bounds bounds)
    {
        List<Node> nodes = new List<Node>();
        char differingAxis = GetDifferingAxis();

        int differingOrigin = Origin.GetAxis(differingAxis);
        int differingEnd = End.GetAxis(differingAxis);

        int minAxis = Coordinate.GetMinAxis(differingAxis, differingEnd);
        int maxAxis = Coordinate.GetMaxAxis(differingOrigin, differingEnd);

        for (int range = minAxis; range < maxAxis; range++)
        {
            Coordinate coordinate;
            switch(differingAxis)
            {
                case 'x':
                    coordinate = new Coordinate(range, Origin.Y);
                    break;
                case 'y':
                    coordinate = new Coordinate(Origin.X, range);
                    break;
                default:
                    throw new Exception();
            }
            
            nodes.Add(CreateNode(coordinate));
        }
        return nodes;
    }

    private int GetMinAxis(char axis)
    {
        return Origin.GetAxis(axis) < End.GetAxis(axis) ? Origin.GetAxis(axis) : End.GetAxis(axis);
    }

    private int GetMaxAxis(char axis)
    {
        return Origin.GetAxis(axis) > End.GetAxis(axis) ? Origin.GetAxis(axis) : End.GetAxis(axis);
    }

    private char GetDifferingAxis()
    {
        return Origin.X != End.X ? 'x' : 'y';
    }

    private char GetCommonAxis()
    {
        return Origin.X == End.X ? 'x' : 'y';
    }
}