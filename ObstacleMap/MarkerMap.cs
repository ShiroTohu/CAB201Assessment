using CAB201_Assignment.Obstacles.Nodes;
using Obstacles;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Util;

/**
 * Responsible for printing out the map, nothing more than that.
 */
namespace CAB201_Assignment.ObstacleMap
{

    public class MarkerMap
    {
        private NodeMap NodeMap;
        private Bounds bounds;
        private char[,] _charMap;

        public MarkerMap(NodeMap nodeMap) 
        {
            NodeMap = nodeMap;

            Coordinate topLeftCoordinate = Input.PromptCoordinate("Enter the location of the top-left cell of the map (X,Y):");
            Coordinate bottomRightCoordinate = Input.PromptCoordinate("Enter the location of the bottom-right cell of the map (X,Y):");
            ValidateInputs(topLeftCoordinate , bottomRightCoordinate);

            bounds = new Bounds(topLeftCoordinate, bottomRightCoordinate);

            _charMap = InitalizeCharMap();
        }

        public void DisplayObstacleMap()
        {
            for (int row = 0; row < _charMap.GetLength(0); row++)
            {
                for (int column = 0; column < _charMap.GetLength(1); column++)
                {
                    string marker = Char.ToString(_charMap[row, column]);
                    if (marker == "\0")
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write($"{marker}");
                    }

                }
                Console.WriteLine();
            }
        }

        private static void ValidateInputs(Coordinate topLeftCoordinate, Coordinate bottomRightCoordinate)
        {
            if (topLeftCoordinate.X > bottomRightCoordinate.X && topLeftCoordinate.Y > bottomRightCoordinate.Y)
            {
                throw new Exception("Invalid Input");
            }  
        }
       
        private char[,] InitalizeCharMap()
        {
            char[,] markerMap = CreateEmptyCharMap();
            List<Obstacle> obstacleList = NodeMap.GetObstacleList();
            Console.WriteLine(obstacleList);
            foreach (Obstacle obstacle in obstacleList)
            {
                List<Node> nodes = obstacle.GetNodes(bounds);
                foreach (Node node in nodes)
                {
                    Console.WriteLine($"{node.X}, {node.Y}");
                    markerMap[node.X, node.Y] = node.Marker;
                    Console.WriteLine("Marker Type: " + markerMap[node.X, node.Y]);
                }
            }

            return markerMap;
        }

        private char[,] CreateEmptyCharMap()
        {
            Console.WriteLine($"{bounds.TopLeftCoordinate.X}, {bounds.BottomRightCoordinate.Y}");
            return new char[bounds.BottomRightCoordinate.X, bounds.BottomRightCoordinate.Y];
        }
    }
}
