using Obstacles;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Map {
    interface MapInterface {
        char[,] GetCharacterGrid();
        void PlaceObstacle(Obstacle obstacle, byte x, byte y);
        Obstacle GetObstacle(byte x, byte y);
    }

    class Map : MapInterface {
        private char[,] _charGrid;
        private Obstacle[,] _obstacleGrid;
        public Map() {
            byte width = 8;
            byte height = 8;
            _charGrid = new char[width, height];
            _obstacleGrid = new Obstacle[width, height];
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

        private char[,] CreateGrid() {
            throw new NotImplementedException();
        }
    }
}