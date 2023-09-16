using Map;
using Obstacles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    interface MenuInterface
    {
        void Menu();
    }

    class MapCreator : MenuInterface
    {
        private ObstacleMap _obstacleMap;
        public void Menu()
        {
            _obstacleMap = new ObstacleMap();
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
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) {
                throw new Exception();
            } else {
                return input;
            }
        }
    }
}
