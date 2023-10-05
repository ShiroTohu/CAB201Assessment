using CAB201_Assignment.ObstacleMap;
using System.Runtime.CompilerServices;

namespace Obstacles {
    interface IObstacle {
        int[] Coordinates { get; }
        int X { get; }
        int Y { get; }
        char Marker { get; }
        List<int[]> GetVision(CharMap charMap);
    }

    public abstract class Obstacle : IObstacle
    {
        protected int _x;
        protected int _y;
        public int[] Coordinates
        {
            get => new int[] { _x, _y };
        }
        public int X
        {
            get => _x;
        }
        public int Y
        {
            get => _y;
        }

        public abstract char Marker
        {
            get;
        }

        // must contain a non-null value when exiting the constructor, though this is supposed to be impleneted in the child classes
        // though raises a good point of how I can clean up the code here.
        protected Obstacle() {
            InitializeObstacle();
        }

        protected abstract void InitializeObstacle();

        public abstract List<int[]> GetVision(CharMap charMap);
    }
}