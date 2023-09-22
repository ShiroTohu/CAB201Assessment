using Obstacles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.ObstacleMap
{
    interface ICharMap
    {
        int[] TopLeftCell { get; }
        int[] BottomRightCell { get; }
        void DisplayMap();
        bool CoordinateInMap(int[] coordinate);
    }

    internal class CharMap : ICharMap
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
            CreateCharMap();
        }

        public void DisplayMap() 
        {
            for (int row = 0; row < _charMap.GetLength(0) ; row++)
            {
                for (int column = 1; column < _charMap.GetLength(1); column++)
                {
                    Console.WriteLine(_charMap);
                    string marker = Char.ToString(_charMap[row, column]);
                    if (string.IsNullOrEmpty(marker))
                    {
                        Console.Write(".");
                    }
                    else 
                    {
                        Console.Write(marker);
                    }
                    
                }
                Console.WriteLine();
            }
        }

        private void CreateCharMap()
        {
            InitalizeMapDimensions();
            foreach (Obstacle obstacle in _obstacles)
            {
                obstacle.GetVision(this);
                _charMap[obstacle.X, obstacle.Y] = obstacle.Marker;
            }
        }

        private void InitalizeMapDimensions()
        {
            int width = _bottomRightCell[0] - _topLeftCell[0];
            int height = _bottomRightCell[1] - _topLeftCell[1];
            _charMap = new char[width, height];
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
