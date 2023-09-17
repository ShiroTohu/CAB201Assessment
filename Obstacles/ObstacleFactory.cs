using System.Runtime.CompilerServices;

namespace Obstacles;
interface ObstacleFactoryInterface
{
    Obstacle CreateObstacle(string type, byte x, byte y);
}

class ObstacleFactory : ObstacleFactoryInterface
{
    public Obstacle CreateObstacle(string type, byte x, byte y) {
        switch(type) {
            case "g":
                return CreateGuard();
            case "f":
                return CreateFence();
            default:
                throw new Exception();

        }
    }

    private Guard CreateGuard() {
        throw new NotImplementedException();
    }

    private Fence CreateFence() {
        throw new NotImplementedException();
    }

    private Camera CreateCamera() {
        throw new NotImplementedException();
    }
}

