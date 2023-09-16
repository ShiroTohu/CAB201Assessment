using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using Obstacles;

namespace Map {
    interface MapInterface {
        char[,] GetGrid();
        char[,] getSafeDirections();
        void PlaceObstacle(Obstacle obstacle, byte x, byte y);
        Obstacle GetObstacle(byte x, byte y);
    }

    class ObstacleMap : MapInterface {
        private Obstacle[,] _grid;
        public ObstacleMap() {
            byte width = 8;
            byte height = 8;
            _grid = new Obstacle[width, height];
        }

        public char[,] GetGrid()
        {
            throw new NotImplementedException();
        }

        public void PlaceObstacle(Obstacle obstacle, byte x, byte y)
        {
            throw new NotImplementedException();
        }

        public Obstacle GetObstacle(byte x, byte y)
        {
            throw new NotImplementedException();
        }
    }
}