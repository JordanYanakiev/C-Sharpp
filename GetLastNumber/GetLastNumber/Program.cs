/* Напишете метод, който връща английското 
 * наименование на последната цифра от дадено 
 * число. Примери: за числото 512 отпечатва
"two"; за числото 1024 – "four". */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLastNumber
{
    class Program
    {
        //This method gets the last number
        public static int GetNumber(int number)
        {
            int n = number % 10;
            return n;
        }

        //This method recognizes the name of the number
        static string TakeNumberName(int number)
        {
            string numberName;
            switch (number)
            {
                case 1:
                    numberName = "One";
                    break;
                case 2:
                    numberName = "Two";
                    break;
                case 3:
                    numberName = "Three";
                    break;
                case 4:
                    numberName = "Four";
                    break;
                case 5:
                    numberName = "Five";
                    break;
                case 6:
                    numberName = "Six";
                    break;
                case 7:
                    numberName = "Seven";
                    break;
                case 8:
                    numberName = "Eight";
                    break;
                case 9:
                    numberName = "Nine";
                    break;
                case 0:
                    numberName = "Zero";
                    break;
                default:
                    return null;
            }
            return numberName;
        }



        static void Main(string[] args)
        {
            Console.Write("Enter a number to read: ");
            int n = int.Parse(Console.ReadLine());

            //Here we use the both methods together
            Console.WriteLine("The last number is " + TakeNumberName(GetNumber(n)));
        }
    }
}
