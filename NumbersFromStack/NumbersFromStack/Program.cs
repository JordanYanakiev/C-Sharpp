using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program which gets N numbers from the console
 * and then prints them in reversed order. 
 * Use Stack<T>.
 */


namespace NumbersFromStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate the stack and the variables to use
            Stack<int> numbers = new Stack<int>();

            int input;
            Console.Write("Enter the amount of numbers you want to enter: ");
            int desiredNumber = int.Parse(Console.ReadLine());

            try  //Guard the code from FormatException if the user does not enter all the numbers
            {
                //Fill the stack
                for (int i = 0; i < desiredNumber; i++)
                {
                    input = int.Parse(Console.ReadLine());
                    numbers.Push(input);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("In the stack you have now {0} numbers!", numbers.Count);
                Console.WriteLine("You need to enter all {0} numbers!", desiredNumber);
                return;
            }

            //Display the amount of numbers in the stack and empty it 
            //displaing the numbers on the screen.
            Console.WriteLine("In the stack we have now {0} numbers!", numbers.Count);
            int middleNumber = numbers.Count;
            for (int j = 1; j <= middleNumber; j++)
            {
                
                Console.WriteLine("Number {0} from the stack is: {1}", j, numbers.Pop());
            }
        }
    }
}
