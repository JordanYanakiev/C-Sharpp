using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*write a program which reads from the console sequence of 
 * positive integer numbers, the sequence is interrupted  
 * when empty row is detected. The program should 
 * sort the numbers in ascending order.
 */


namespace SortNumbersFromList
{
    class Program
    {
        //Create method for entering numbers and storing them into List<int>
        static void EnterNumbers(List<int> integers)
        {
            //Create variables 
            int inputNumber = 0;
            string inputString = "0";
            
            //While we enter numbers in the List the loop will be active 
            //When we receive empty input the loop is deactivated
            while (!String.IsNullOrEmpty(inputString))
            {
                Console.Write("Please enter a number: ");
                inputString = Console.ReadLine();

                if (!String.IsNullOrEmpty(inputString))
                {
                    inputNumber = int.Parse(inputString);

                    if (inputNumber < 0)
                    {
                        throw new System.ArgumentOutOfRangeException
                            ("inputNumber", inputNumber, "You need to enter positive integer number!");
                    }
                    if (inputNumber > 0)
                    {

                        integers.Add(inputNumber);
                    }
                }
            }
        }

        //Method for the numbers from the previously created list 
        //and printing them in the console in ascending order
        static void Sort(List<int> integers)
        {
            integers.Sort();
            int listLength = integers.Count;
            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine((int)integers[i]);
            }
        }
        
        static void Main(string[] args)
        {
            //Create list
            List<int> myInts = new List<int>();

            //Use the method to populate the list
            EnterNumbers(myInts);

            //Sort the numbers and prin them in ascending order
            Sort(myInts);
            
        }
    }
}
