/* Напишете програма, която
прочита три цели числа от конзолата и 
отпечатва най-голямото от
тях, използвайки метода GetMax(). */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxNumber
{
    class Program
    {
        //The method which will return the bigest number
        static void GetMax(int number1, int number2, int number3)
        {

            if (number1 > number2 && number1 > number3)
            {
                    Console.WriteLine(number1);
            }

            if (number2 > number3 && number2 > number1)
            {
                    Console.WriteLine(number2);
            }

            if (number3 > number1 && number3 > number2)
            {
                    Console.WriteLine(number3);
            }

            if (number1 == number2 && number2 == number3)
            {
                Console.WriteLine("All numbers are equal!");
            }
            
        }


        static void Main(string[] args)
        {
            //Entering the numbers
            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int number3 = int.Parse(Console.ReadLine());

            //Using the GetMax method
            GetMax(number1, number2, number3);

        }
    }
}
