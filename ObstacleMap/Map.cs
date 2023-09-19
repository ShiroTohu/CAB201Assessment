using Obstacles;

namespace CAB201_Assignment.ObstacleMap 
{
    /// <summary>
    /// The Interface to be implemented by the ObstacleMap
    /// </summary>
    interface MapInterface
    {
        /// <summary>
        /// returns the grid as a two dimensional array
        /// </summary>
        /// <returns></returns>
        char[,] GetGrid();
        string ShowSafeDirections();

        string DisplayObstacleMap();
        string FindSafePath();
        void PlaceObstacle(Obstacle obstacle);
        Obstacle GetObstacle(byte x, byte y);
    }

    class Map : MapInterface
    {
        private Obstacle[,] _grid;
        public Map()
        {
            byte width = 8;
            byte height = 8;
            _grid = new Obstacle[width, height];
        }

        public char[,] GetGrid()
        {
            throw new NotImplementedException();
        }

        public string ShowSafeDirections()
        {
            Console.WriteLine("Enter the location where the fence ends (X,Y):");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            seperate = input.Split(",");
            byte endX = byte.Parse(seperate[0]);
            byte endY = byte.Parse(seperate[1]);
        }

        public string DisplayObstacleMap()
        {
            throw new NotImplementedException();
        }

        public string FindSafePath()
        {
            throw new NotImplementedException();
        }

        public void PlaceObstacle(Obstacle obstacle)
        {
            Console.WriteLine("Placed Obstacle");
        }

        public Obstacle GetObstacle(byte x, byte y)
        {
            throw new NotImplementedException();
        }
    }
}
