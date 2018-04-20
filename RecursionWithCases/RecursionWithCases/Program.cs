using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionWithCases
{
    
        class Program
        {
        //This recursive method counts backwards
            private static int RecursionBackward(int n, int i)
            {
                if (n == i)
                {
                    return n;
                }
                else
                    Console.WriteLine(n);
                return RecursionBackward(n - 1, i);
            }

        //This recursive method counts forward
            private static int RecursionForward(int n, int i)
            {
                if (n == i)
                {
                    return n;
                }
                else
                    Console.WriteLine(n);
                return RecursionForward(n + 1, i);
            }

        static void Main(string[] args)
            {
            //Initialise the variables we are about to use
            Console.Write("Please enter your staring number: ");
                int StartNumber = int.Parse(Console.ReadLine());
                Console.Write("Please enter your ending number: ");
                int EndNumber = int.Parse(Console.ReadLine());

            //Makes decison which method to use
            if (StartNumber > EndNumber)
            {
                Console.WriteLine(RecursionBackward(StartNumber, EndNumber));
            }
            else
                Console.WriteLine(RecursionForward(StartNumber, EndNumber));

            }
        }
}

