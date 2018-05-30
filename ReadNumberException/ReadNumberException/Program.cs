using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadNumberException
{
    class Program
    {
        //Method with exception catch
          static public void ReadNumber (int start, int end, string enter)
        {
            try
            {
                int number = int.Parse(enter);
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException) //catch exception for input outside the boundaries
            {
                Console.WriteLine("===================================");
                Console.WriteLine("The number is either less than {0} or greater than {1}!", start, end);
                Console.WriteLine();
                System.Environment.Exit(1);  // Exit from the application
            }
            catch (FormatException)  //catch exception for wrong input
            {
                Console.WriteLine("===================================");
                Console.WriteLine(enter + " is wrong input!");
                Console.WriteLine();
                System.Environment.Exit(1);  // Exit from the application
            }   
            finally // Even without exception do this
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for taking part!");
                Console.WriteLine("===================================");
            }
        }

        //********************************************************************************************************************************************************************************************

        static void Main(string[] args)
        {
            //Initialize array to store values in it and variables
            string[] numbers = new string[10] {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            int inputStart;
            int inputEnd;
            string enter;
            //Request information from the user
            Console.Write("Enter the start point, please: ");
            inputStart = int.Parse(Console.ReadLine());
            Console.Write("Enter the end point, please: ");
            inputEnd = int.Parse(Console.ReadLine());
            
            //Fill the array with values
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the number tou want to check, please: ");
                enter = Console.ReadLine();
                ReadNumber(inputStart, inputEnd, enter);
                numbers[i] = enter;
            }

            //Output the array with the stored values in it
            for (int i = 0; i <10; i++)
            {
                Console.Write(" " + numbers[i]);
            }
        }
    }
}
