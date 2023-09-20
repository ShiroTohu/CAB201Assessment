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

    abstract class Obstacle : IObstacle
    {
        protected char _marker;
        protected int[] _coordinates; // origin of the Obsticle
        public int[] Coordinates
        {
            get => _coordinates;
        }
        public int X
        {
            get
            {
                byte x = 0;
                return _coordinates[x];
            }
            
        }
        public int Y
        {
            get 
            { 
                byte y = 1;
                return _coordinates[y];
            }
        }

        public char Marker
        {
            get
            {
                return _marker;
            }
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