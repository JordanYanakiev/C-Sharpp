using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program which reads a file and then 
 * adds a number to the rows. */


namespace AddNumbersToRows
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create reader for the original file and writer for the new file
            Encoding encoded =  Encoding.GetEncoding("UTF-8");
            StreamReader readFile = new StreamReader("file.txt", encoded);
            StreamWriter write1 = new StreamWriter("newFile.txt");
           
            //Create string in which we will store the readed rows from the original file
            //And counter for the rows
            string readed = readFile.ReadLine();
            int number = 0;

            //Write a new line in the new text file which contains 
            //the number of the row and the line from the original document
            while (readed != null)
            {
                number++;
                write1.WriteLine(number + "..." + readed);
                Console.WriteLine(readed);
                readed = readFile.ReadLine();
            }

            //Close the reader and the writer
            write1.Close();
            readFile.Close();            
        }
    }
}
