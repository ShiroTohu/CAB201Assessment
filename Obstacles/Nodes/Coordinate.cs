using CAB201_Assignment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace CAB201_Assignment.Obstacles.Nodes
{
    interface ICoordinate
    {
        int X { get; }
        int Y { get; }
        public int[] Position { get; }
    }

    /// <summary>
    /// Coordinates is not a physical point on a map. Instead it is an imaginary point.
    /// </summary>
    public class Coordinate
    {
        public int X { get; }
        public int Y { get; }
        public int[] Position { get => new int[] { X, Y }; }

        /// <summary>
        /// Node Constructor where the x and y coordinates are specified by the parameters.
        /// </summary>
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Node Constructor where the x and y coordinates are specified by the user input.
        /// /// </summary>
        public Coordinate(string prompt)
        {
            int[] coordinates = PromptCoordinates(prompt);

            byte x = 0;
            byte y = 1;

            X = coordinates[x];
            Y = coordinates[y];
        }

        /// <summary>
        /// Prompts the user for coordinates as an x,y pair. Example input: 1,2
        /// </summary>
        /// <returns>
        /// An array of integers representing the coordinates where index of 0 and 1
        /// represents the x and y coordinates inputted by the user.
        /// </returns>
        /// <example>
        /// The following code demonstrates how to use the method
        /// <code>
        /// int[] input = PromptCoordinates("Enter the position of the Guard (X,Y)")
        /// input[0] // x
        /// input[1] // y
        /// </code>
        /// </example>
        private static int[] PromptCoordinates(string prompt)
        {
            string input = InputCoordinates(prompt);
            return CoordinateStringToIntArray(input);
        }

        /// <summary>
        /// InputCoordinates takes the input of the user
        /// </summary>
        private static string InputCoordinates(string prompt)
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
            // TODO: One misuse of this funciton is if the coordinates is specified like this 1,,2, this should raise an Exception.
            int x = int.Parse(coordinates[0]);
            int y = int.Parse(coordinates[1]);

            return new int[] { x, y };
        }
    }
}
