using Obstacles;

namespace CAB201_Assignment.ObstacleMap
{
    class MapCreator
    {
        private Map _obstacleMap;
        public MapCreator()
        {
            _obstacleMap = new Map();
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
                /* 
                You could use some polymorphism here but I'll let you do that
                sort of thing when you refactor the ultimately horrible code
                that you will try and produce as a result of the ever
                encroaching deadline.
                */
                case "g":
                    
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
