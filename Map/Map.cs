namespace Map {
    interface MapInterface {
        byte[8,8] getMap();

        private void createMap();
    }

    class Map : MapInterface {
        byte[8, 8] map;
        public void Map() {
            map = createMap()
        }

        private byte[8, 8] createMap() {
            throw new NotImplementedError;
        }
    }
}