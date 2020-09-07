using Abstract_skolklasser.Models;
using System;
using System.Collections.Generic;

namespace Abstract_skolklasser
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var classlist = new List<Person>

            {
                
                new Teacher { FirstName = "Hans", LastName = "Mattin-Lassei",ClassName ="Na3B" ,Role="Teacher"},
                new Teacher { FirstName = "Johanna", LastName = "Lundgren", ClassName = "Te3A", Role = "Teacher"},
                new Student { FirstName = "Samuel", LastName = "Wessén", ClassName = "Te3A"},
                new Student { FirstName = "Mikael", LastName = "Wessén", ClassName = "Te3A"},
                new Student { FirstName = "Daniel", LastName = "Wessén", ClassName = "Te3A"},
                
                
            };

            foreach(var person in classlist)
            {
                if (person is Teacher teacher)
                    Console.WriteLine($"{teacher.FirstName} {teacher.LastName} - {teacher.ClassName} - {teacher.Role}");
                if (person is Student student)
                    Console.WriteLine($"{student.FirstName} {student.LastName} - {student.ClassName} ");
                else
                    Console.Write("");
                
            }
                


        }
    }
}
