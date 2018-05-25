using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter an integer number
            int number;
            Console.Write("Enter a numbe by your choice: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is {0}!", number);
            

            //If the number is negative catch an Exception
            if (number < 0)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Your number is {0}.", number);
                }
                catch (Exception)
                {
                   Console.WriteLine("FATAL ERROR! The number must be positive");
                }
                  finally
                {
                   Console.WriteLine("Thank you for taking part! Good bye!");
                }   
            }
        }
    }


    
}

