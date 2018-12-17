using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program which calculates numbers by the sequence formula 
 * S1 = N;
   S2 = S1 + 1;
   S3 = 2*S1 + 1;
   S4 = S1 + 2;
   S5 = S2 + 1;
   S6 = 2*S2 + 1;
   S7 = S2 + 2;
   and display the first 50 members of the sequence.
 **/

namespace CreateFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter = 0;
            Queue<int> formula = new Queue<int>(); //Initiate the queue and the variables to use
            int N, S1, S2, S3, S4, S5, S6, S7;
            int endAt; 

            //Input the number to calculate and the end condition
            Console.Write("Enter a number for start: ");
            number = int.Parse(Console.ReadLine());
            formula.Enqueue(number); //Enqueue the number in the Queue
            N = number;
            Console.Write("Enter the amoount of transition you want to see: ");
            endAt = int.Parse(Console.ReadLine());

            while( formula.Count > 0)
            {
                counter++; //Increment the counter and display the first thing in the Queue
                Console.WriteLine("Row {0} => Number {1}", counter, formula.Dequeue());
                if(counter == endAt) //If the end condition is met end the loop
                {
                    return;
                }

                //Enter into the queue the calculated values from the formula
                formula.Enqueue(S1 = N);
                formula.Enqueue(S2 = S1 + 1);
                formula.Enqueue(S3 = 2 * S1 + 1);
                formula.Enqueue(S4 = S1 + 2);
                formula.Enqueue(S5 = S2 + 1);
                formula.Enqueue(S6 = 2 * S2 + 1);
                formula.Enqueue(S7 = S2 + 2);
            }
        }
    }
}
