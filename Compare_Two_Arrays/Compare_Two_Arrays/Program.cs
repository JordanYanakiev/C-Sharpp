/* Да се напише програма, която чете 
 * два масива от конзолата и проверява 
 * дали са еднакви. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter the lenght of the arrays
            Console.Write("Enter the lenght of your arrays: ");
            int lenght =  int.Parse(Console.ReadLine());

            //Initialize the two arrays
            int[] array1 = new int[lenght];
            int[] array2 = new int[lenght];

            //Filling the two arrays
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Please, enter value for the first array: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int j = 0; j < lenght; j++)
            {
                Console.Write("Please, enter value for the SECOND ARRAY: ");
                array2[j] = int.Parse(Console.ReadLine());
            }

            //Compare the two arrays if they are equal
            Console.WriteLine();
            bool a = array1.SequenceEqual(array2);
            Console.WriteLine("Arrays equality: " + a);
        }
    }
}
