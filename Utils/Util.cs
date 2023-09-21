using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB201_Assignment.Utils
{
    class Util
    {
        public static int[] PromptCoordinates(string prompt)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception();
            }
            string[] seperate = input.Split(",");
            int x = byte.Parse(seperate[0]);
            int y = byte.Parse(seperate[1]);

            return new int[] { x, y };
        }
    }
}
