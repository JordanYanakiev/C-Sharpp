using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExcercise
{
    class Program
    {
        /* Define class Student, which keeps the folowing 
         * information about the students: three names, course (year in University), soecialty,
         * University Name, e-mail and phone number. */

        enum Universities {Unavailable, Technical_University_Gabrovo, Plovdiv_University, Sofia_University, Sofia_Technical_University}
        enum Specialties {Unavailable, Automation, Bulgarian_Philology, Computer_Science, Applied_Physics, Applied_Math, Informatics}
        
        class Student
        {
            //Declare Fields of the class Student
            public static int StudentsCount = 0;
            private string StudentFirstName = null;
            private string StudentFathersName = null;
            private string StudentLastName = null;  
            private string StudentCourse = null;
            private Universities StudentUniversity;
            private Specialties StudentSpecialty;
            private string StudentEmail = "none";
            private string StudentPhoneNumber;
            
            //Declare properties
            public string FirstName
            {
                get { return StudentFirstName; }
                set { StudentFirstName = value; }
            }

            public string FathersName
            {
                get { return StudentFathersName; }
                set { StudentFathersName = value; }
            }

            public string LastName
            {
                get { return StudentLastName; }
                set { StudentLastName = value; }
            }

            public string Course
            {
                get { return StudentCourse; }
                set { StudentCourse = value; }
            }

            public Universities University
            {
                get { return StudentUniversity; }
                set { StudentUniversity = value; }
            }

            public Specialties Specialty
            {
                get { return StudentSpecialty; }
                set { StudentSpecialty = value; }
            }

            public string Email
            {
                get { return StudentEmail; }
                set { StudentEmail = value; }
            }

            public string PhoneNumber
            {
                get { return StudentPhoneNumber; }
                set { StudentPhoneNumber = value; }
            }

                //Create constructors for Student Class, respectively these will be few overloads 
                //with some of the information for the student or no informaton if none of the overloads fit
                //so we could manualy enter the information for the student
            public Student (string StudentFirstName, string StudentFathersName, string StudentLastName)
            {
                this.StudentFirstName = StudentFirstName;
                this.StudentFathersName = StudentFathersName;
                this.StudentLastName = StudentLastName;
                this.StudentUniversity = this.University;
                StudentsCount += 1;
            }

            public Student(string StudentFirstName, string StudentLastName, string StudentCourse, Universities StudentUniversity, string StudentEmail, string StudentPhoneNumber)
            {
                this.StudentFirstName = StudentFirstName;
                this.StudentLastName = StudentLastName;
                this.StudentCourse = StudentCourse;
                this.StudentUniversity = StudentUniversity;
                this.StudentEmail = StudentEmail;
                this.StudentPhoneNumber = StudentPhoneNumber;
                StudentsCount += 1;
            }

            public Student (string StudentFirstName, Universities StudentUniversity, Specialties StudentSpecialty )
            {
                this.StudentFirstName = StudentFirstName;
                this.StudentUniversity = StudentUniversity;
                this.StudentSpecialty = StudentSpecialty;
                StudentsCount += 1;
            }

            public Student()
            {
                StudentsCount += 1;
            }
            
            //Method for displaying the ino for the student
            public void StudentInfo()
            {
                Console.WriteLine("The full name of the student is {0} {1} {2}, he/she studies in {3} with specialty {4}, his/her e-mail addres is {5} and the phone number is {6}", this.StudentFirstName, this.StudentFathersName, this.StudentLastName,
                this.StudentUniversity, this.StudentSpecialty, this.StudentEmail, this.StudentPhoneNumber);
            }
    
        }
        
        static void Main(string[] args)
        {
            //Testing the Stuent Class and the method StudentInfo()
            Student Ivan = new Student("Ivan", "Kirov", "4", Universities.Sofia_University, "comeandseeme@abv.bg", "0899898989");
            Ivan.StudentInfo();
            Student Nikola = new Student();
            Nikola.FirstName = "Nikola";
            Nikola.FathersName = "Georgiev";
            Nikola.LastName = "Petrov";
            Nikola.University = Universities.Plovdiv_University;
            Nikola.Specialty = Specialties.Applied_Math;
            Nikola.PhoneNumber = "0887696969";
            Nikola.StudentInfo();
        }
    }
}
