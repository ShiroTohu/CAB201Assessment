using System.Runtime.CompilerServices;

namespace Obstacles {
    interface ObstacleInterface {
        int[] Coordinates { get; }
        int X { get; }
        int Y { get; }
        char Marker { get; }
        List<int[]> GetVision(int[] topLeft, int[] bottomRight);
    }

    abstract class Obstacle : ObstacleInterface 
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

        protected static int[] PromptCoordinates(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            string[] seperate = input.Split(",");
            int x = byte.Parse(seperate[0]);
            int y = byte.Parse(seperate[1]);

            return new int[] { x, y };
        }

        public abstract List<int[]> GetVision(int[] topLeft, int[] bottomRight);
    }
}