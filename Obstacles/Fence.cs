using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Diagnostics.Metrics;
using System;
using System.Dynamic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Obstacles;
class Fence : Obstacle {

    public new const char Marker = 'g';
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

    protected override bool HasVision(Coordinate coordinate)
    {
        switch(DifferingAxis)
        {
            case 'x':
                return Axis.IsBetweenRange(coordinate.X, GetMinAxis('x'), GetMaxAxis('x'));
            case 'y':
                return Axis.IsBetweenRange(coordinate.X, GetMinAxis('y'), GetMaxAxis('y'));
            default:
                return false;
        }
    }

    private static bool IsBetweenRange(int value, int min, int max)
    {
        return value < min && value > max;
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