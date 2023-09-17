namespace Obstacles;
interface ObstacleFactoryInterface
{
    Obstacle CreateObstacle(string type, byte x, byte y);
}

class ObstacleFactory : ObstacleFactoryInterface
{
    public Obstacle CreateObstacle(string type, byte x, byte y) {
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
        Console.WriteLine($"Enter the Guard's location (X, Y):");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) {
                throw new Exception();
            } 
            string[] seperate = input.Split();
            byte x = byte.Parse(seperate[0]);
            byte y = byte.Parse(seperate[1]);

            return new Guard(x, y);
    }

    private Fence CreateFence() {
        Console.WriteLine($"Enter the Fence's location (X, Y):");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) {
            throw new Exception();
        } 
        string[] seperate = input.Split();
        byte x = byte.Parse(seperate[0]);
        byte y = byte.Parse(seperate[1]);

        return new Fence(x, y);
    }

    private Camera CreateCamera() {
        Console.WriteLine($"Enter the Fence's location (X, Y):");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) {
            throw new Exception();
        } 
        string[] seperate = input.Split();
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
        string[] seperate = input.Split();
        byte x = byte.Parse(seperate[0]);
        byte y = byte.Parse(seperate[1]);

        return new Sensor(x, y);
    }
}

