using System.Diagnostics.Metrics;
using System;
using System.Runtime.CompilerServices;

namespace Obstacles;
interface ObstacleFactoryInterface
{
    Obstacle CreateObstacle(string type);
}

class ObstacleFactory : ObstacleFactoryInterface
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
            case "m":
                return CreateMineField();
            default:
                throw new Exception();
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

