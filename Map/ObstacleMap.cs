using Obstacles;

namespace CAB201_Assignment.Map 
{
    interface MapInterface
    {
        char[,] GetGrid();
        char[,] GetSafeDirections();
        void PlaceObstacle(Obstacle obstacle, byte x, byte y);
        Obstacle GetObstacle(byte x, byte y);
    }

    class ObstacleMap : MapInterface
    {
        private Obstacle[,] _grid;
        public ObstacleMap()
        {
            byte width = 8;
            byte height = 8;
            _grid = new Obstacle[width, height];
        }

        public char[,] GetGrid()
        {
            throw new NotImplementedException();
        }

        public char[,] GetSafeDirections()
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
