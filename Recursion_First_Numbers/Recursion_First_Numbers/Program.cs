using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_First_Numbers
{
    class Program
    {
        static public int FirstNumbers(int endNumber)
        {
            if (endNumber == 0)
            {
                return 0;
            }

            else
            {
                Console.WriteLine(endNumber);
              return FirstNumbers(endNumber - 1);
            }

        }



        static void Main(string[] args)
        {

            Console.WriteLine(FirstNumbers(10));


        }
    }
}
