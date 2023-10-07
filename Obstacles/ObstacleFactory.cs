using System.Diagnostics.Metrics;
using System;
using System.Runtime.CompilerServices;

namespace Obstacles;
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
    public Obstacle CreateObstacle(string type) 
    {
        switch(type) 
        {
            case "g":
                return CreateGuard();
            case "f":
                return CreateFence();
            case "c":
                return CreateCamera();
            case "s":
                return CreateSensor();
            case "mf":
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

