
    //Write a program which asks the user 
    //to enter a number, then the program should calculate 
    //square root from the same number, 
    //if the number is negative (Number < 0)
    //Exception should be called; 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //Put the guarded code inside the TRY part
                try
                {
                    //Initialize a number, then ask for input from the user
                    double number;
                    Console.Write("Enter a number to squrare root: ");
                    number = double.Parse(Console.ReadLine());

                //If the number is less than zero throw an Exception -> ArgumentOutOfRangeException
                   if (number < 0)
                        {
                          throw new System.ArgumentOutOfRangeException();
                        }
                   //Calculate the Squared Root of the number and output the information
                    double calculated = Math.Sqrt(number);
                    Console.WriteLine();
                    Console.WriteLine("Your number square rooted is: {0}", calculated);
                }
                //Exception for handling wrong input from the user
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("The number has to be with comma not with point!");
                }
                //Exception for handling number less than zero
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine();
                    Console.WriteLine("The number has to be POSITIVE!");
                }

                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for taking part!");
                    Console.WriteLine();
                }
        }
    }
}
