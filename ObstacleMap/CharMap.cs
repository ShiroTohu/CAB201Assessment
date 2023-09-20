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
        void Display();
        bool CoordinateInMap(int[] coordinate);
    }

    internal class CharMap : ICharMap
    {
        private char[,] _charMap;
        private int[] _topLeftCell;
        private int[] _bottomRightCell;

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

        public CharMap(int[] topLeftCell, int[] topRightCell, List<Obstacle> obstacles) 
        {
            
        }

        public void Display() 
        {
            throw new NotImplementedException();
        }

        private void InitalizeMapDimensions(int[] topLeftCell, int[] topRightCell)
        {

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
