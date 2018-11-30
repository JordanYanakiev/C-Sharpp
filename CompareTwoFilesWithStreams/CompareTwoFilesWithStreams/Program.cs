using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program which compares two files 
 * and prints the number of equal rows and 
 * the number of different rows */


namespace CompareTwoFilesWithStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create stream readers for file 1 and 2
                Encoding encode = Encoding.GetEncoding("UTF-8");
                StreamReader read1 = new StreamReader("file1.txt", encode);
                StreamReader read2 = new StreamReader("file2.txt", encode);

                string line1 = read1.ReadLine();
                string line2 = read2.ReadLine();

            //Create counters for same and diferent rows
                int countDuplicate = 0;
                int countDifferent = 0;


                while (line1 != null || line2 != null)
                {

                    //If the files are not equally long throw exception that says the files are with diferent lenght
                    if ((line1 != null && line2 == null) || (line1 == null && line2 != null))
                    {
                        throw new Exception("One of both files is longer! Please, make sure the files are equally long!");
                    }

                    //Compare the lines and update the counters accordingly
                    if (line1 == line2)
                    {
                        countDuplicate++;
                    }
                    else
                        countDifferent++;

                    line1 = read1.ReadLine();
                    line2 = read2.ReadLine();
                }


                //Show the result and clse the streams
                Console.WriteLine("The rows that mach are {0} and the rows that don't are {1}", countDuplicate, countDifferent);

                read1.Close();
                read2.Close();
            


        }
    }
}
