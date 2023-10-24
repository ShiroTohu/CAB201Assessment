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
    public class Coordinate : IEquatable<Coordinate>
    {
        public Axis X { get; }
        public Axis Y { get; }
        public Axis[] Position { get => new Axis[] { X, Y }; }
        private static byte x = 0;
        private static byte y = 1;

        /// <summary>
        /// Node Constructor where the x and y coordinates are specified by the parameters.
        /// </summary>
        public Coordinate(int x, int y)
        {
            X = new Axis(x);
            Y = new Axis(y);
        }

        public Coordinate(int[] postiion)
        {
            X = Position[x];
            Y = Position[y];
        }

        /// <summary>
        /// Node Constructor where the x and y coordinates are specified by the user input.
        /// /// </summary>
        public Coordinate(string prompt)
        {
            Axis[] coordinates = PromptCoordinates(prompt);

            X = coordinates[x];
            Y = coordinates[y];
        }

        public bool Equals(Coordinate? otherCoordinate)
        {
            if (otherCoordinate == null)
            {
                return false;
            }
                
            return (Position == otherCoordinate.Position);
        }

        public override bool Equals(Object? obj)
        {
            return this.Equals(obj as Axis);
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
