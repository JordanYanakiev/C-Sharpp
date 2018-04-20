/*"This program prints n amount of numbers, 
with defined start and end" */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionReverseCount
{
    class Program
    {
        private static int Recursion(int n, int i)
        {
            if (n == i)
            {
                return n;
            }
            else
                Console.WriteLine(n);
            return Recursion(n - 1, i);
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter your staring number: ");
            int StartNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter your ending number: ");
            int EndNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(StartNumber, EndNumber));

        }
    }
}
