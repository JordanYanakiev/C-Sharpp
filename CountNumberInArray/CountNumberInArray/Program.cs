/* Напишете метод, който намира 
 * колко пъти дадено число се среща в
даден масив. */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberInArray
{
    class Program
    {

        //The method that will count the numbers in the array
        static void CountNumberInArray(int[] array1, int number)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
               if (array1[i] == number)
               {
                    count++;
               } 
            }
            Console.WriteLine();
            Console.WriteLine("The number {0} is seen {1} times in the array!", number, count);
            Console.WriteLine();
        }

        //========================================================================================

        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());

            //Initialise the array
            int[] numbersArray = new int[length];

            //Filling the array
            for (int i = 0; i < length; i++)
            {
                Console.Write("Please, enter number: ");
                numbersArray[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Please enter a number to search in the array: ");
            int searchNumber = int.Parse(Console.ReadLine());

            //Use of the method CountNumberInArray 
            CountNumberInArray(numbersArray, searchNumber);
        }
    }
}
