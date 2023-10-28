using CAB201_Assignment.Obstacles.Nodes;
using Obstacles;
using System.Runtime.CompilerServices;
using Util;

/**
 * Responsible for printing out the map, nothing more than that.
 */
namespace CAB201_Assignment.ObstacleMap
{

    public class MarkerMap
    {

        public MarkerMap(NodeMap nodeMap) 
        {
            Coordinate topLeftCoordinate = Input.PromptCoordinate("Enter the location of the top-left cell of the map (X,Y):");
            Coordinate bottomRightCoordinate = Input.PromptCoordinate("Enter the location of the bottom-right cell of the map (X,Y):");
            ValidateInputs(topLeftCoordinate , bottomRightCoordinate);

            _markerMap = InitalizeCharMap();
            DisplayMap();
        }

        public void DisplayObstacleMap()
        {

        }

        private static void ValidateInputs(Coordinate TopLeftCell, Coordinate BottomRightCell)
        {
            if (TopLeftCell.X > BottomRightCell.X && TopLeftCell.Y > BottomRightCell.Y)
            {
                throw new Exception("Invalid Input");
            }  
        }

        private void DisplayMap()
        {
            for (int row = 0; row < _markerMap.GetLength(0); row++)
            {
                for (int column = 0; column < _markerMap.GetLength(1); column++)
                {
                    string marker = Char.ToString(_markerMap[row, column]);
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
       
        private char[,] InitalizeCharMap()
        {
            char[,] markerMap = CreateEmptyCharMap();
            List<Obstacle> obstacleList = NodeMap.GetObstacleList();
            Console.WriteLine(obstacleList);
            foreach (Obstacle obstacle in obstacleList)
            {
                List<Node> nodes = obstacle.GetNode(TopLeftCell, BottomRightCell);
                foreach (Node node in nodes)
                {
                    markerMap[node.X, node.Y] = node.Marker;
                }
            }

            return markerMap;
        }

        private char[,] CreateEmptyCharMap()
        {
            return new char[BottomRightCell.X, BottomRightCell.Y];
        }
    }
}
