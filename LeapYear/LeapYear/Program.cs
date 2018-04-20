/*  
 
 Write a program which checks if a year is leap or not.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is leap year!", year);
            }
            else
                Console.WriteLine("{0} is not leap year!", year);

        }
    }
}
