using Obstacles;

namespace CAB201_Assignment.ObstacleMap
{
    class MapCreator
    {
        private Map _map;
        public MapCreator()
        {
            _map = new Map();
            Menu();
        }

        private void Menu()
        {
            bool completed = false;
            while (!completed) {
                DisplayPrompt();
                string input = enterCode();
                CodeSelector(input);
                if (input == "x") {
                    completed = true;
                }
            }
            
        }

        private void DisplayPrompt()
        {
            Console.WriteLine("Select one of the following options");
            Console.WriteLine("g) Add 'Guard' obstacle");
            Console.WriteLine("f) Add 'Fence' obstacle");
            Console.WriteLine("s) Add 'Sensor' obstacle");
            Console.WriteLine("c) Add 'Camera' obstacle");
            Console.WriteLine("d) Show safe directions");
            Console.WriteLine("m) Display obstacle map");
            Console.WriteLine("p) Find safe path");
            Console.WriteLine("x) Exit");
        }

        private string enterCode()
        {
            Console.WriteLine("Enter code:");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            else
            {
                return input;
            }
        }

        private void CodeSelector(string code)
        {
            ObstacleFactory obstacleFactory = new ObstacleFactory();
            try
            {
                Obstacle obstacle = obstacleFactory.CreateObstacle(code);
                _map.PlaceObstacle(obstacle);
            }
            catch (Exception)
            {
                throw;
            }

            switch (code)
            {
                /* 
                You could use some polymorphism here but I'll let you do that
                sort of thing when you refactor the ultimately horrible code
                that you will try and produce as a result of the ever
                encroaching deadline.
                */
                case "d":
                    _map.ShowSafeDirections();
                    break;
                case "m":
                    _map.DisplayObstacleMap();
                    break;
                case "p":
                    _map.FindSafePath();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}