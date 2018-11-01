using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program which extracts the unucode 
 * code of the characters of a word entered from the console.  */

namespace ConvertToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to check its' Unicode encoding: ");
            string word = Console.ReadLine();
            char[] symb = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                symb[i] = word[i];

                Console.Write("u{0:x4} \\ ", Convert.ToUInt16(symb[i]));
            }
            Console.WriteLine();
        }
    }
}
