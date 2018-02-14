/* Създайте метод GetMax() с два 
 * целочислени (int) параметъра, който
връща по-голямото от двете числа. */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetingTheMaxValue
{
    class Program
    {
        //The method which will return the bigest number
        static void GetMax (int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            if (number1 < number2)
            {
                Console.WriteLine(number2);
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number: ");
            int number2 = int.Parse(Console.ReadLine());

            GetMax(number1, number2);

        }
    }
}
