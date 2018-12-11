using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program which gets whole
 * numbers and stores them in List<T>.
 * Calculate the sum from the numbers and
 * the average from them.
 */


namespace ListOfNumbersCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate variables and the List
            List<int> numbers = new List<int>();
            string digit = "0";
            int number;
            int sum = 0;
            int average = 0;
            
            //Add numbers until there is empty row detected
            while (!String.IsNullOrEmpty(digit))
            {
                Console.Write("Enter value for numbers: ");
                digit = Console.ReadLine();
                if (!String.IsNullOrEmpty(digit))
                {
                    number = int.Parse(digit);
                    numbers.Add(number);
                }
            }

            //Calculate the numbers from the list (sum and average)
            Console.WriteLine("=================");
            for (int j = 0; j < numbers.Count; j++)
            {
                sum += numbers[j];
            }
            Console.WriteLine("The total sum from all numbers in the list is: {0}", sum);
            average = sum / numbers.Count;
            Console.WriteLine("The average rom all numbers in the list is: {0}", average);

        }
    }
}
