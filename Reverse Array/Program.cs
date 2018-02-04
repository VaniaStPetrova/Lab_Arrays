using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] serie = Console.ReadLine().Split(' ').ToArray();

            string[] invertedSerie = serie.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", invertedSerie));

        }
    }
}
