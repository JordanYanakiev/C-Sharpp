/* Да се напише програма, която сравнява два масива от тип char
лексикографски (буква по буква) и проверява кой от двата е по-рано
в лексикографската подредба. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of your array: ");
            int lenght = int.Parse(Console.ReadLine());

            char[] array1 = new char[lenght];
            char[] array2 = new char[lenght];
            int count1 = 0;
            int count2 = 0;

            //Filling the arrays
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter value for array1: ");
                array1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter value for array2: ");
                array2[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            //Compare the arrays
            char tempchar1, tempchar2;
            for (int i = 0; i<lenght; i++)
            {
                tempchar1 = array1[i];
                tempchar2 = array2[i];
                if (tempchar1 < tempchar2)
                {
                    Console.WriteLine("{0} is before {1}", array1[i], array2[i]);
                    count1++;
                }
                if (tempchar1 > tempchar2)
                {
                    Console.WriteLine("{0} is before {1}", array2[i], array1[i]);
                    count2++;
                }
                if (tempchar1 == tempchar2)
                {
                    Console.WriteLine("{0} and {1} are equal", array2[i], array1[i]);
                }

            }

            //Compare size of counters and decides which array is first
            if ( count1 > count2)
            {
                Console.WriteLine("Array1 is before Array2!");
            }
            if (count1 < count2)
            {
                Console.WriteLine("Array2 is before Array1!");
            }
            if (count1 == count2)
            {
                Console.WriteLine("Array1 is equal to Array2!");
            }
        }
    }
}
