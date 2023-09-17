namespace Obstacle {
    class ObstacleFactory {
        public  Obstacle CreateObstacle() {

        }
        public Guard Factory() {
            Console.WriteLine("Enter the guard's location (X, Y):");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) {
                throw new Exception();
            } 
            string[] seperate = input.Split();
            return new Guard(byte.Parse( seperate[0]), byte.Parse(seperate[1]));
        }
    }
}


