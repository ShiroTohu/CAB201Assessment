using CAB201_Assignment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.ObstacleMap.Nodes
{
    interface INode
    {
        int[] PromptCoordinates(string prompt);
    }
    public class Node
    {
        public int X { get; }
        public int Y { get; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Node(string prompt)
        {
            int[] coordinates = PromptCoordinates(prompt);
            
            // I much rather a little bit of memory be used for more readability.
            byte x = 0;
            byte y = 1;

            X = coordinates[x];
            Y = coordinates[y];
        }

        public static int[] PromptCoordinates(string prompt)
        {
            string input = inputCoordinates(prompt);
            return CoordinateStringToIntArray(input);
        }

        private static string inputCoordinates(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            return input;
        }

        private static int[] CoordinateStringToIntArray(string inputCoordinates)
        {
            string[] coordinates = inputCoordinates.Split(",");
            int x = int.Parse(coordinates[0]);
            int y = int.Parse(coordinates[1]);

            return new int[] { x, y };
        }
    }
}
