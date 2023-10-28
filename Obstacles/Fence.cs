using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Diagnostics.Metrics;
using System;
using System.Dynamic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Obstacles;
public class Fence : Obstacle {
    public new const bool IsIgnored = false;

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

    public Fence() : base(Marker)
    {
        Origin = new Coordinate("Enter the location where the fence starts(X, Y):");
        End = new Coordinate("Enter the location where the fence ends (X,Y):");
        ValidateObstacleOrientation();
        GetNodes(new Bounds(new Coordinate(0,0), new Coordinate(7, 7)));
        Console.WriteLine("balls");
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

    public override Bounds GetBounds()
    {
        return new Bounds(Origin, End);
    }

    public override List<Node> GetNodes(Bounds bounds)
    {
        List<Node> nodes = new List<Node>();
        char differingAxis = GetDifferingAxis();
        Console.WriteLine(differingAxis); //correct

        int differingOrigin = Origin.GetAxis(differingAxis);
        int differingEnd = End.GetAxis(differingAxis);
        Console.WriteLine($"{differingOrigin}, {differingEnd}"); // correct

        int minAxis = Coordinate.GetMinAxis(differingOrigin, differingEnd);
        Console.WriteLine(minAxis);
        int maxAxis = Coordinate.GetMaxAxis(differingOrigin, differingEnd);
        Console.WriteLine(maxAxis);

        Console.Write(minAxis <= maxAxis);

        for (int range = minAxis; range <= maxAxis; range++)
        {
            Coordinate coordinate;
            
            switch (differingAxis)
            {
                case 'x':
                    coordinate = new Coordinate(range, Origin.Y);
                    nodes.Add(CreateNode(coordinate));
                    break;
                case 'y':
                    coordinate = new Coordinate(Origin.X, range);
                    Console.WriteLine($"bafdfbfd {Origin.X} {range}");
                    nodes.Add(CreateNode(coordinate));
                    break;
                default:
                    throw new Exception();    
            }
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