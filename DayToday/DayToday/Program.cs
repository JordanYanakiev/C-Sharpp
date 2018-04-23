/* 
 Write a program which displays on the console
 the curent day of the week.  
  */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (DateTime.Now.DayOfWeek); 
        }
    }
}
