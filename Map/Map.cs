using Obstacles;

namespace Map {
    interface MapInterface {
        byte[,] getGrid   
    }

    class Map : MapInterface {
        byte[,] grid;
        public Map() {
            grid = new byte[8, 8];
        }

        public byte[,] getGrid()
        {
            throw new NotImplementedException();
        }

        private byte[,] createGrid() {
            throw new NotImplementedException();
        }
    }
}