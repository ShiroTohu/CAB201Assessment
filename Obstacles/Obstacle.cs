using CAB201_Assignment.ObstacleMap;
using CAB201_Assignment.Obstacles.Nodes;
using System.Runtime.CompilerServices;

namespace Obstacles
{
    interface IObstacle {
        int[] Coordinates { get; }
        int X { get; }
        int Y { get; }
        Node HasVision(Coordinate coordinate);
    }

    // I CAN'T MAKE THE MARKER ENFORCABLE BY THE ABSTRACT CLASS WITHOUT REMOVING THE CONST ATTRIBUTE WHICH IN TURNS WON'T ALLOW ME TO USE IT IN SWITHCES.
    public abstract class Obstacle : IObstacle
    {
        public static char Marker;
        protected abstract Coordinate Origin { get; }
        protected abstract NodeFactory NodeFactory { get; }
        public int X { get => Origin.X; }
        public int Y { get => Origin.Y; }
        public int[] Coordinates { get => new int[] { X, Y }; }
        public abstract Node HasVision(Coordinate coordinate);
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