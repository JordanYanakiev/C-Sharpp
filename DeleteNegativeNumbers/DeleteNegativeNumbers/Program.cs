using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program which deletes the negative 
 * numbers from an entry array. For example  
 * array = {19, -10, 12, -6, -3, 34, -2, 5}  {19, 12, 34, 5}
 */


namespace DeleteNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 19, -10, 12, -6, -3, 34, -2, 5 }; 
            List<int> positiveNumbers = new List<int>();
            int positiveNumberLength = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    positiveNumbers.Add(array[i]); //Adds the positive numberrs in the List
                }
            }

            //Goes through the list to read the numbers stored there
            positiveNumberLength = positiveNumbers.Count;
            for (int j = 0; j < positiveNumberLength; j++)
            {
                Console.WriteLine(positiveNumbers[j]);
            }


        }
    }
}
