using CAB201_Assignment.Utils;
using Obstacles;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        void DisplayObstacleMap();
        void FindSafePath();
        void PlaceObstacle(Obstacle obstacle);
        int[] GetMapBounds();
    }

    public class Map : IMap
    {
        private List<Obstacle> _obstacles;
        public List<Obstacle> Obstacles
        {
            get
            {
                return _obstacles;
            }
        }

        public Map()
        {
            _obstacles = new List<Obstacle>();
        }

        public string ShowSafeDirections()
        {
            Util.PromptCoordinates("Enter your current location(X, Y)");

            return "Example output: SEWN";
        }

        public void DisplayObstacleMap()
        {
            CharMap charMap = CreateCharMap();
            charMap.DisplayMap();
        }

        public void FindSafePath()
        {
            PathFinding.Main(this);
        }

        public void PlaceObstacle(Obstacle obstacle)
        {
            _obstacles.Add(obstacle);
        }

        private CharMap CreateCharMap()
        {
            int[] topLeftCell = Util.PromptCoordinates("Enter the location of the top-left cell of the map (X,Y):");
            int[] bottomRightCell = Util.PromptCoordinates("Enter the location of the top-left cell of the map (X,Y):");
            return new CharMap(topLeftCell, bottomRightCell, _obstacles);
        }



        public int[] GetMapBounds()
        {
            int x = 0;
            int y = 0;

            foreach (Obstacle obstacle in _obstacles)
            {
                if (obstacle.X > x)
                {
                    x = obstacle.X;
                }
                if (obstacle.Y > y) 
                {
                    y = obstacle.Y;
                }
            }

            return new int[] { x, y };
        }
    }
}
