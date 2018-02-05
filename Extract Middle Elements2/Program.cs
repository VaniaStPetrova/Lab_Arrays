using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (answer.Length == 1)
            {
                Console.Write("{ ");
                Console.Write("{0}",answer[0]);
                Console.Write(" }");
            }
            else if (answer.Length % 2 == 0)
            {
                Console.Write("{ ");
                Console.Write("{0}, {1}", answer[answer.Length / 2 - 1], answer[answer.Length / 2]);
                Console.Write(" }");
            }
            else
            {
                Console.Write("{ ");
                Console.Write("{0}, {1}, {2}", answer[answer.Length / 2 - 1], answer[answer.Length / 2], answer[answer.Length / 2 + 1]);
                Console.Write(" }");
            }
        }
    }
}
