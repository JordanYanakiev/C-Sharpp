/* 
 Write a program which calculates the vlue of 
 the hypotenuse by given two kattes. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypotenuseCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize and enter the values of the kattes
            Console.Write("Katte 1 = ");
            double katte1 = double.Parse(Console.ReadLine());
            Console.Write("Katte 2 = ");
            double katte2 = double.Parse(Console.ReadLine());

            // Initialize the hypotenuse and calculating its value
            double hypotenuse = Math.Sqrt(Math.Pow(katte1, 2) + Math.Pow(katte2, 2));
            Console.WriteLine("Hypotenuse = {0}", Math.Round(hypotenuse, 2));  // Displays the value of the hypotenuse with precison set to two symbols after the comma
        }
    }
}
