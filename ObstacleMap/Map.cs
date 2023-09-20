using Obstacles;

namespace CAB201_Assignment.ObstacleMap 
{
    /// <summary>
    /// The Interface to be implemented by the ObstacleMap
    /// </summary>
    interface IMap
    {
        string ShowSafeDirections();

        /// <summary>
        /// Generates the string representation of the Obstacle Map using
        /// the Obstacles found in 
        /// </summary>
        /// <returns></returns>
        string DisplayObstacleMap();
        string FindSafePath();
        void PlaceObstacle(Obstacle obstacle);
        Obstacle GetObstacle(int x, int y);
    }

    class Map : IMap
    {
        private List<Obstacle> _obstacles;
        public Map()
        {
            _obstacles = new List<Obstacle>();
        }

        public string ShowSafeDirections()
        {
            Console.WriteLine("Enter the location where the fence ends (X,Y):");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }

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
            _obstacles.Add(obstacle);
        }

        public Obstacle GetObstacle(int x,int y)
        {
            throw new NotImplementedException();
        }

        private void RenderVision(int[] topLeftCoordinates, int[] bottomRightCoordinates) // rename later
        {
            char[,] charmap = new char[,]
            foreach (var obstacle in _obstacles)
            {
                List<int[]> obstacleVision = obstacle.GetVision(topLeftCoordinates, bottomRightCoordinates);

            }
        }
    }
}
