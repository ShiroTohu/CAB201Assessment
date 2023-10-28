using CAB201_Assignment.ObstacleMap;
using Util;
using Obstacles;

class Program
{
    private static NodeMap _nodeMap = new NodeMap();
    private static bool loopCompleted = false;
    static void Main(string[] args)
    {
        DisplayLoop();
    }
        
    private static void DisplayLoop()
    {
        while (!loopCompleted)
        {
            DisplayPrompt();
            char input = Input.PromptChar("x) Exit");
            CodeSelector(input);
            if (input == 'x') { break; }
        }
    }

    private static void DisplayPrompt()
    {
        Console.WriteLine("Select one of the following options");
        Console.WriteLine("g) Add 'Guard' obstacle");
        Console.WriteLine("f) Add 'Fence' obstacle");
        Console.WriteLine("s) Add 'Sensor' obstacle");
        Console.WriteLine("c) Add 'Camera' obstacle");
        Console.WriteLine("d) Show safe directions");
        Console.WriteLine("m) Display obstacle map");
        Console.WriteLine("p) Find safe path");
    }

    private static void CodeSelector(char input)
    {
        try
        {
            _nodeMap.AddObstacle(input);
        } catch (ObstacleNotFound)
        {
            Console.WriteLine("ObstacleNotFound");
            switch (input)
            {
                case 'd':
                    _nodeMap.ShowSafeDirections();
                    break;
                case 'm':
                    _nodeMap.DisplayObstacleMap();
                    break;
                case 'p':
                    _nodeMap.FindSafePath();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
