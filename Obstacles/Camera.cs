using CAB201_Assignment.Obstacles.Nodes;
using Util;
using System.Data;
using System.Diagnostics.Metrics;

namespace Obstacles;
public class Camera : Obstacle 
{
    public new const bool IsIgnored = true;
    public new const char Marker = 'c';
    // in a perfect world and to save memory we want all instances of the class to implement the same factory instance
    public override Coordinate Origin { get; }
    private char[] _directions = new char[4] { 'n', 'e', 's', 'w'};
    public char Direction { get; }

    public Camera()
    {
        Origin = new Coordinate("Enter the MineField's location (X,Y):");
        Direction = PromptDirection("Enter the direction the camera is facing(n, s, e or w):");
    }

    private char PromptDirection(string prompt)
    {
        char input = Input.PromptChar(prompt);
        if (_directions.Contains(input))
        {
            return input;
        }
        throw new Exception();
    }

    public override bool HasVision(Coordinate coordinate)
    {
        double opposite = GetRange(coordinate.X, Origin.X);
        double adjacent = GetRange(coordinate.Y, Origin.Y);

        double angle = Math.Atan(opposite / adjacent) * (180 / Math.PI);

        bool withinVision = angle <= 45 && angle >= -45;
        bool validOrientation = CheckOrientation(coordinate);

        return withinVision && validOrientation;
    }

    private bool CheckOrientation(Coordinate coordinate)
    {
        if ((Direction == 'n' && Origin.Y <= coordinate.Y) ||
            (Direction == 'e' && Origin.X <= coordinate.X) ||
            (Direction == 's' && Origin.Y >= coordinate.Y) ||
            (Direction == 'w' && Origin.X >= coordinate.X))
        {
            return true;
        }
        return false;
    }

    private int GetRange(int axis1, int axis2)
    {
        return Coordinate.GetMaxAxis(axis1, axis2) - Coordinate.GetMinAxis(axis1, axis2);
    }

    public override Bounds GetBounds()
    {
        if (IsIgnored)
        {
            throw new Exception("IsIgnored field set to true");
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}