using Obstacles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/**
 * Responsible for printing out the map, nothing more than that.
 */
namespace CAB201_Assignment.ObstacleMap
{
    interface ICharMap
    {
        int[] TopLeftCell { get; }
        int[] BottomRightCell { get; }
        void DisplayMap();
        bool CoordinateInMap(int[] coordinate);
    }

    public class CharMap : ICharMap
    {
        private char[,] _charMap;
        private int[] _topLeftCell;
        private int[] _bottomRightCell;
        private List<Obstacle> _obstacles;

        public int[] TopLeftCell
        {
            get
            {
                return _topLeftCell;
            }
        }

        public int[] BottomRightCell
        {
            get
            {
                return _bottomRightCell;
            }
        }

        public CharMap(int[] topLeftCell, int[] bottomRightCell, List<Obstacle> obstacles) 
        {
            _topLeftCell = topLeftCell;
            _bottomRightCell = bottomRightCell;
            _obstacles = obstacles;
            _charMap = CreateCharMap();
        }

        public void DisplayMap() 
        {
            for (int row = 0; row < _charMap.GetLength(0) ; row++)
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

        private char[,] CreateCharMap()
        {
            char[,] charMap = InitalizeEmptyMap();
            foreach (Obstacle obstacle in _obstacles)
            {
                int[] coordinates = ConvertToRelativeCoordinate(obstacle.GetVision(this)[0]);
                Console.WriteLine($"{coordinates[0]}, {coordinates[1]}");
                charMap[coordinates[0], coordinates[1]] = obstacle.Marker;
            }
            return charMap;
        }

        private int[] ConvertToRelativeCoordinate(int[] coordinate)
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
        }
    }
}
