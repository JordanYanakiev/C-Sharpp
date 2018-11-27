using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintUnevenRow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat StreamReader object
            StreamReader read = new StreamReader("readThis.txt", Encoding.GetEncoding("UTF-8"));

            //Initialise string to store the read line and cunter for the rows
            string line = read.ReadLine();
            int lineCounter = 0;

            using (read)
            {
                //Read the file and take only the uneven rows
                while (line != null)
                {
                    //Increment the counter
                    lineCounter++;
                    if (lineCounter % 2 != 0)
                    {
                        //Write the content of the line if it is uneven
                        Console.WriteLine(line);
                    }
                    //Go and read the next line
                    line = read.ReadLine();

                }
            }
        }
    }
}
