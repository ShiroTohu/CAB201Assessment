using System.Diagnostics.Metrics;
using System;
using System.Runtime.CompilerServices;
using Obstacles;

namespace CAB201_Assignment.ObstacleMap;
[Serializable]
public class ObstacleNotFound : Exception
{
    public ObstacleNotFound() { }

    public ObstacleNotFound(string message)
        : base(message) { }

    public ObstacleNotFound(string message, Exception inner)
        : base(message, inner) { }
}

public class ObstacleFactory
{
    protected Guard CreateGuard()
    {
        Console.WriteLine("Guard has been created");
        return new Guard();
    }

    protected Fence CreateFence()
    {
        return new Fence();
    }

    protected Camera CreateCamera()
    {
        return new Camera();
    }

    protected Sensor CreateSensor()
    {
        return new Sensor();
    }

    protected MineField CreateMineField()
    {
        return new MineField();
    }
}

