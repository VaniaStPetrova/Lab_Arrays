using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool check = false;
            for (int arrayI = 0; arrayI < num.Length; arrayI++)
            {
                for (int number = arrayI + 1; number < num.Length; number++)
                {
                    int sumOfTwoNums = num[arrayI] + num[number];
                    if (num.Contains(sumOfTwoNums))
                    {
                        Console.WriteLine("{0} + {1} == {2}", num[arrayI], num[number], sumOfTwoNums);
                        check = true;
                    }
                }

            }

            if (check == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
