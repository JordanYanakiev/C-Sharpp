using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program which reads the information from 
 two separate files and writes it into third. */


namespace CombineIntoOneFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create StreamReader for the two files
            StreamReader read1 = new StreamReader("file_one.txt", Encoding.GetEncoding("UTF-8"));
            StreamReader read2 = new StreamReader("file_two.txt", Encoding.GetEncoding("UTF-8"));

            //Read the whole 2 files
            string line1 = read1.ReadToEnd();
            string line2 = read2.ReadToEnd();

            //Create the third file and write the information from file1 then close the 
            //StreamReader and the StreamWriter for read1 and write1
            StreamWriter write1 = new StreamWriter("file_three.txt");
            write1.Write(line1);
            write1.Close();
            read1.Close();

            //Add the information from file2 into "file_three" then close the 
            //StreamReader and the StreamWriter for read2 and write2
            StreamWriter write2 = new StreamWriter("file_three.txt", append: true);
            write2.Write(line2);
            write2.Close();
            read2.Close();
        }
    }
}
