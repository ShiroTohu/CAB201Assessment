namespace Obstacles {
    abstract class Obstacle {
        private readonly char _marker;
        public char Marker
        {
            get { return _marker; }
        }

        public Obstacle(byte x, byte y) {
            
        }    
    }
}