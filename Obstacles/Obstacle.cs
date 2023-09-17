namespace Obstacles {
    interface ObstacleInterface {
        byte[] GetPosition();
        char GetMarker();
    }

    abstract class Obstacle : ObstacleInterface {
        private char _marker;
        private byte _x;
        private byte _y;

        protected Obstacle(byte x, byte y) {
            _x = x;
            _y = y;
        }

        public byte[] GetPosition() {
            return new byte[2] {_x, _y};
        }

        public char GetMarker() {
            return _marker;
        }
    }
}