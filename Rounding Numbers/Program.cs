using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            for (int loop = 0; loop < numbers.Length; loop++)
            {
                Console.WriteLine("{0} => {1}", numbers[loop], Math.Round(numbers[loop], MidpointRounding.AwayFromZero));
            }
        }
    }
}
