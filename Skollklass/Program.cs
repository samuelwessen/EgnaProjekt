using Skollklass.models;
using Skollklass.Models;
using System;
using System.Collections.Generic;

namespace Skollklass
{
    class Program
    {
        static void Main(string[] args)
        {
            var classlist = new List<Person>()
            {
                new Teachers {FirstName = "Hans", LastName = "Andersson", Gender = "Male", City = "Örebro",Class = "Te3B"},
                new Teachers {FirstName = "Olle", LastName = "Ulfssson", Gender = "Male", City = "Örebro",Class = "Na2A"},

                new Students {FirstName = "Samuel", LastName = "Wessen", Gender = "Bojke", City = "Örebro", NumberOfParents = 2},
                new Students {FirstName = "Mikael", LastName = "Wessen", Gender = "Liten Bojke", City = "Örebro", NumberOfParents = 3},
                new Students {FirstName = "Daniel", LastName = "Wessen", Gender = "Liten Bojke", City = "Örebro", NumberOfParents = 1},
            };

            foreach (var person in classlist)
            {
                if (person is Teachers teacher)
                    Console.WriteLine($"{teacher.FirstName} {teacher.LastName} - {teacher.Gender} - {teacher.City} - {teacher.Class}");
                if (person is Students students)
                    Console.WriteLine($"{students.FirstName} {students.LastName} - {students.Gender} - {students.City} - {students.NumberOfParents}");
                else
                    Console.Write("");
            }

        }
    }
}
