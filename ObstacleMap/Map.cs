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
        Obstacle GetObstacle(int x, int y);
    }

    class Map : MapInterface
    {
        private Obstacle[,] _grid;
        public Map()
        {
            int width = 8;
            int height = 8;
            _grid = new Obstacle[width, height];
        }

        public char[,] GetGrid()
        {
            throw new NotImplementedException();
        }

        public string ShowSafeDirections()
        {
            Console.WriteLine("Enter the location where the fence ends (X,Y):");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            string[] seperate = input.Split(",");
            byte endX = byte.Parse(seperate[0]);
            byte endY = byte.Parse(seperate[1]);

            return "SEWN";
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

        public Obstacle GetObstacle(int x,int y)
        {
            throw new NotImplementedException();
        }
    }
}
