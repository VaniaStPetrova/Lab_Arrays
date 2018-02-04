using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            
            int[] intArray = new int[arraySize];
            for (int i = arraySize - 1; i >= 0; i--)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}
