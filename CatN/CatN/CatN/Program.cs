/*          
 Напишете програма, която създава 10 обекта от тип Cat, дава им
имена от вида CatN, където N e уникален пореден номер на обекта, и
накрая извиква метода SayMiau() на всеки от тях. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatN
{

    

    class Program
    {
        //Create Class Cat
        public  class Cat
        {
            public string name;
            public string color;
            
            public  Cat (string Name, string Color)
            {
                name = Name;
                color = Color;
            }

            public Cat()
            {
                this.name = "Cat";
                this.color = "Black and white, and some blue";
            }
            
            
            public void  SayMyau()
            {
                Console.Write("{0} said: Myau!", this.name);
            }

        }

        //Create the Sequence class and NextValue method
        public class Sequence
        {
            private static int currentValue = 0;

            public static int NextValue()
            {
                currentValue++;
                return currentValue;
            }
        }

        
        static void Main(string[] args)
        { 
            //Create List of objects Cats
            List<Cat> catsList = new List<Cat>();

            for (int i = 1; i <= 10; i++)
            {
                Cat newCat = new Cat();
                string number = Convert.ToString(Sequence.NextValue());
                Console.WriteLine( "The color of {0} {1} is {2} ", newCat.name, number , newCat.color);

                //Add NextValue number to the default name
                newCat.name = newCat.name + number;
                newCat.SayMyau();
                Console.WriteLine();
                Console.WriteLine("========================================================");
            }
        }
    }
}
