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

interface IObstacleFactory
{
    Obstacle CreateObstacle(string type);
}

class ObstacleFactory : IObstacleFactory
{
    public Obstacle CreateObstacle(char type)
    {
        switch (type)
        {
            case Guard.Marker:
                return CreateGuard();
            case Fence.Marker:
                return CreateFence();
            case Camera.Marker:
                return CreateCamera();
            case Sensor.Marker:
                return CreateSensor();
            case MineField.Marker:
                return CreateMineField();
            default:
                throw new ObstacleNotFound();
        }
    }

    private Guard CreateGuard()
    {
        return new Guard();
    }

    private Fence CreateFence()
    {
        return new Fence();
    }

    private Camera CreateCamera()
    {
        return new Camera();
    }

    private Sensor CreateSensor()
    {
        return new Sensor();
    }

    private MineField CreateMineField()
    {
        return new MineField();
    }
}

