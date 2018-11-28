using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


/* Write a program which capitalises only certain words in the given text. */
namespace CaseChangeAtCertainWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string longText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine(longText);
           
            string newString = Regex.Replace(longText, @"yellow submarine", "YELLOW SUBMARINE");
            string newString1 = Regex.Replace(newString, @"anything", "ANYTHING");
            string replacedString1 = Regex.Replace(newString1, @"<upcase>", " ");
            string replacedString2 = Regex.Replace(replacedString1, @"</upcase>", " ");
            Console.WriteLine(replacedString2);
            
        }
    }
}
