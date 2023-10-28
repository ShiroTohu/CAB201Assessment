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
        private NodeMap NodeMap { get; }
        public Coordinate TopLeftCell { get; }

        public Coordinate BottomRightCell { get; }
        private char[,] _markerMap;

        public MarkerMap(NodeMap nodeMap) 
        {
            NodeMap = nodeMap;
            TopLeftCell = Input.PromptCoordinate("Enter the location of the top-left cell of the map (X,Y):");
            BottomRightCell = Input.PromptCoordinate("Enter the location of the bottom-right cell of the map (X,Y):");
            CheckInputs();

            _markerMap = InitalizeCharMap();
            DisplayMap();
        }

        private void CheckInputs()
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
                List<Node> nodes = obstacle.GetCoverage(TopLeftCell, BottomRightCell);
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

        /*private int[] ConvertToRelativeCoordinate(int[] coordinate)
        {
            int x = coordinate[0];
            int y = coordinate[1];
            return new int[] { x - TopLeftCell[0], y - TopLeftCell[1] };
        }

        private char[,] InitalizeEmptyMap()
        {
            int width = _bottomRightCell[0] - _topLeftCell[0] + 1;
            int height = _bottomRightCell[1] - _topLeftCell[1] + 1;
            char[,] emptyMap = new char[width, height];
            return emptyMap;
        }

        public bool CoordinateInMap(int[] coordinate)
        {
            int x = coordinate[0];
            int y = coordinate[1];
            if (XInRange(x) && YInRange(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // possibly refactor the below since they are quite similar
        private bool XInRange(int x)
        {
            if (x >= TopLeftCell[0] && x <= BottomRightCell[0])
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private bool YInRange(int y)
        {
            if (y >= TopLeftCell[1] && y <= BottomRightCell[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
