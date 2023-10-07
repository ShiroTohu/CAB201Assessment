using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Runtime.CompilerServices;

namespace Obstacles
{
    interface IObstacle {
        int[] Coordinates { get; }
        int X { get; }
        int Y { get; }
        Node HasVision(int x, int y);
    }

    public abstract class Obstacle : IObstacle
    {
        protected abstract Coordinate Origin { get; }
        protected abstract NodeFactory NodeFactory { get; }
        public int X { get => Origin.X; }
        public int Y { get => Origin.Y; }
        public int[] Coordinates { get => new int[] { X, Y }; }
        public abstract Node HasVision(int x, int y);
    }

    [Serializable]
    public class ObsticleHasNoVision : Exception
    {
        public ObsticleHasNoVision() { }

        public ObsticleHasNoVision(string message)
            : base(message) { }

        public ObsticleHasNoVision(string message, Exception inner)
            : base(message, inner) { }
    }
}