namespace Obstacles {
    interface ObstacleInterface {
        int[] GetPosition();
        char GetMarker();
    }

    abstract class Obstacle : ObstacleInterface {
        private char _marker;
        private int _x;
        private int _y;

        protected Obstacle(int x, int y) {
            _x = x;
            _y = y;
        }

        protected Obstacle()
        {
            byte x = 0;
            byte y = 1;
            int[] coordinates = PromptCoordinates("asdf");
            _x = coordinates[x];
            _y = coordinates[y];
        }

        public int[] GetPosition() {
            return new int[2] {_x, _y};
        }

        public char GetMarker() {
            return _marker;
        }

        protected static int[] PromptCoordinates(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            string[] seperate = input.Split(",");
            int x = byte.Parse(seperate[0]);
            int y = byte.Parse(seperate[1]);

            return new int[] { x, y };
        }
    }
}