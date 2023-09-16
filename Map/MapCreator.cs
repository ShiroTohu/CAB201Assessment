namespace CAB201_Assignment.Map
{
    class MapCreator
    {
        private ObstacleMap _obstacleMap;
        public MapCreator()
        {
            _obstacleMap = new ObstacleMap();
            Menu();
        }

        private void Menu()
        {
            DisplayPrompt();
            string input = enterCode();
            CodeSelector(input);
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
            switch (code)
            {
                case "g":
                    Console.WriteLine("g");
                    break;
                case "f":
                    Console.WriteLine("f");
                    break;
                case "s":
                    Console.WriteLine("s");
                    break;
                case "c":
                    Console.WriteLine("c");
                    break;
                case "d":
                    Console.WriteLine("d");
                    break;
                case "m":
                    Console.WriteLine("m");
                    break;
                case "p":
                    Console.WriteLine("p");
                    break;
                case "x":
                    Console.WriteLine("x");
                    break;
            }
        }
    }
}
