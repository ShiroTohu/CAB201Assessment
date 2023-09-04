namespace Obstacles {
    abstract class Obstacle {
        private byte x;
        private byte y;
        public byte[2] coordinates {
            get {
                return new byte[2] {x, y};
            }
        }

        public Obstacle(byte x, byte y) {
            this.x = x;
            this.y = y;
        }    
    }
}