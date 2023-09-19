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

        protected Obstacle()
        {

        }

        public byte[] GetPosition() {
            return new byte[2] {_x, _y};
        }

        public char GetMarker() {
            return _marker;
        }

        protected static byte[] PromptCoordinates(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            string[] seperate = input.Split(",");
            byte x = byte.Parse(seperate[0]);
            byte y = byte.Parse(seperate[1]);

            return new byte[] { x, y };
        }
    }
}