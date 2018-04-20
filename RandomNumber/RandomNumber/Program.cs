/* 
 Write a program which prints a random number in the range from 100 to 200.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + number.Next(100, 200) + " ");
            }
            
        }
    }
}
