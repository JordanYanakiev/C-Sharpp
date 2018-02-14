/* Напишете метод, който при подадено име отпечатва в конзолата
"Hello, <name>!" (например "Hello, Peter!") */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNamedGreeting
{
    class Program
    {
        //The method which will display the greeting
        static void DisplayGreeting(string name)
        {
            Console.WriteLine();
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();
            DisplayGreeting(name);
        }
    }
}
