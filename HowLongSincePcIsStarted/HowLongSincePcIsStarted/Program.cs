/* 
 Write a program which displays the days, 
 the hours and the minutes passed since 
 starting the computer.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowLongSincePcIsStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = Environment.TickCount;
            int seconds = time / 1000;
            int minutes = seconds / 60;
            int secondsLeftover = seconds % 60;
            int hours = minutes / 60;
            int minutesLeftover = minutes % 60;
            int days = hours / 24;
            int hoursLeftover = hours % 24;
            Console.WriteLine(days + "d " + hours + "h " + minutesLeftover + "m " + secondsLeftover + "s ");
            
        }
    }
}
