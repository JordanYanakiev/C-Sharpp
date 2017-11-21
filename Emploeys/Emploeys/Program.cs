using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emploeys
{
    class Program
    {
        public class Employe
            {
             // name, surname, age, gender
             public string name;
             public string lastname;
             public int age;
             public string gender;



            public Employe (string Name, string LastName, int Age, string Gender)
                {
                    name = Name;
                    lastname = LastName;
                    age = Age;
                    gender = Gender;
                }   

              public override string ToString()
            {
                return "Employe: " + " " + name + " " + lastname + " " + age + " " + gender;
            }

        }




        static void Main(string[] args)
        {
            Console.Write("Enter number of employes you want to have: ");
            int n = Int32.Parse(Console.ReadLine());
            List<Employe> employesList = new List<Employe>();


            //Create ammount of objects
            for (int i = 1; i <= n; i++)
            {

                string name, lastname;
                int age;
                string gender;

                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.Write("Enter last name: ");
                lastname = Console.ReadLine();

                Console.Write("Enter age: ");
                age = Int32.Parse(Console.ReadLine());

                Console.Write("Enter gender: ");
                gender = Console.ReadLine();

                Employe employeee = new Employe(name, lastname, age, gender);

                // Console.WriteLine(employeee.name + " " + employeee.lastname + " " + employeee.age + " " + employeee.gender);
                employesList.Add(employeee);
            }


            Console.WriteLine();

            //Sega mi vadi unhadled exception, predpolagam che e neshto ot List-a 
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("======================================================");
                Console.WriteLine();
                Console.WriteLine(employesList[i]);
                Console.WriteLine();
            }


            Console.WriteLine(" Choose how to sort the employes:");
            Console.WriteLine(" 1 Sort by name.");
            Console.WriteLine(" 2 Sort by last name.");
            Console.WriteLine(" 3 Sort by age.");
            Console.WriteLine(" 4 Sort by gender male.");
            Console.WriteLine(" 5 Sort by gender female.");
            Console.Write("Enter your wish for sorting: ");
            int ChooseOption = Int32.Parse(Console.ReadLine());


            //Izbor kakva inforamciya da izvede na konzolata spored zadaden kriterii
            switch (ChooseOption)
            {
                //Pechati po kriterii 
                //Kriterii 1 malko ime
                case 1:
                    for (int i = 0; i < n; i++)
                    {

                        Console.WriteLine("======================================================");
                        Console.WriteLine();
                        Console.WriteLine(employesList[i].name + " " + employesList[i].lastname);
                        Console.WriteLine();
                    }
                    break;

                //Kriterii 2 - Familno ime
                case 2:
                    for (int i = 0; i < n; i++)
                    {

                        Console.WriteLine("======================================================");
                        Console.WriteLine();
                        Console.WriteLine(employesList[i].lastname + " " + employesList[i].name);
                        Console.WriteLine();
                    }
                    break;


                //Kriterii 3 - vyzrast
                case 3:
                    for (int i = 0; i < n; i++)
                    {

                        Console.WriteLine("======================================================");
                        Console.WriteLine();
                        Console.WriteLine(employesList[i].age + " " + employesList[i].name + " " + employesList[i].lastname);
                        Console.WriteLine();
                    }
                    break;
                //Kriterii 4 - pol myje
                case 4:
                    string male;
                    for (int i = 0; i < n; i++)
                    {

                        Console.WriteLine("======================================================");
                        Console.WriteLine();
                        male = employesList[i].gender;
                        if (male == "male")
                        {
                            Console.WriteLine(employesList[i].gender + " " + employesList[i].name + " " + employesList[i].lastname);
                            Console.WriteLine();
                        }
                    }
                    break;
            

            //Kriterii 5 - pol jeni
                case 5:
                    string female;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("======================================================");
                Console.WriteLine();
                male = employesList[i].gender;
                if (male == "female")
                {
                    Console.WriteLine(employesList[i].gender + " " + employesList[i].name + " " + employesList[i].lastname);
                    Console.WriteLine();
                }
            }
            break;
            }

        }
    }
}
