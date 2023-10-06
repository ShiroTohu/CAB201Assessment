using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Runtime.CompilerServices;

namespace Obstacles
{
    interface IObstacle {
        int[] Coordinates { get; }
        int X { get; }
        int Y { get; }
        char Marker { get; }
        List<int[]> GetVision(CharMap charMap);
    }

    public abstract class Obstacle : IObstacle
    {
        protected readonly char Marker;
        protected abstract Coordinate Origin { get; }
        protected abstract NodeFactory NodeFactory { get; }
        public readonly char Marker { get; }
        public int X { get => Origin.X; }
        public int Y { get => Origin.Y; }
        public int[] Coordinates { get => new int[] { X, Y }; }
        public abstract List<int[]> GetVision(CharMap charMap);
    }
}