using System.Diagnostics.Metrics;
using System;

namespace Obstacles;
interface ObstacleFactoryInterface
{
    Obstacle CreateObstacle(string type);
}

class ObstacleFactory : ObstacleFactoryInterface
{
    public Obstacle CreateObstacle(string type) {
        switch(type) {
            case "guard":
                return CreateGuard();
            case "fence":
                return CreateFence();
            case "camera":
                return CreateCamera();
            case "sensor":
                return CreateSensor();
            default:
                throw new Exception();
        }
    }

    private Guard CreateGuard() {
        

        return new Guard();
    }

    private Fence CreateFence() {
        byte x = 0;
        byte y = 0;
        Console.WriteLine("Enter the location where the fence starts(X, Y):");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) {
            throw new Exception();
        } 
        int[] startingcoordinates =

        Console.WriteLine("Enter the location where the fence ends (X,Y):");
        input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            throw new Exception();
        }
        seperate = input.Split(",");
        byte endX = byte.Parse(seperate[0]);
        byte endY = byte.Parse(seperate[1]);

        return new Fence();
    }

    private Camera CreateCamera() {
        Console.WriteLine($"Enter the Fence's location (X, Y):");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) {
            throw new Exception();
        } 
        string[] seperate = input.Split(",");
        byte x = byte.Parse(seperate[0]);
        byte y = byte.Parse(seperate[1]);

        return new Camera(x, y);
    }

    private Sensor CreateSensor() {
        Console.WriteLine($"Enter the Fence's location (X, Y):");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) {
            throw new Exception();
        } 
        string[] seperate = input.Split(",");
        byte x = byte.Parse(seperate[0]);
        byte y = byte.Parse(seperate[1]);

        return new Sensor(x, y);
    }
}

