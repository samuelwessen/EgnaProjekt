using InsertStudent.Models;
using System;
using System.Collections.Generic;

namespace InsertStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            List<Student> studentlista = new List<Student>();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("[1] Lägg till en ny Elev");
                Console.WriteLine("[2] Visa alla elever");
                Console.WriteLine("[3] Avlsuta programmet");
                int menyval = Convert.ToInt32(Console.ReadLine());
                switch (menyval)               

                {             

                    case 1:
                        Console.WriteLine("Var god skriv elevens förnamn:");
                        student.FirstName = Console.ReadLine();
                        Console.WriteLine("Var god skriv elevens efternamn:");
                        student.LastName = Console.ReadLine();
                        Console.WriteLine("Var god skriv hur gammal eleven är:");
                        student.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tack eleven är nu sparad");                        
                        studentlista.Add(new Student());
                        break;
                    case 2:
                        foreach (Student student1 in studentlista)
                        {
                            Console.WriteLine($"({student.FirstName} {student.LastName} - {student.Age} )");
                        }
                        break;
                    case 3:
                        isRunning = false;
                        break;               



                }



            }

        }
    }
}

