using C14_Abstruct_1.Models;
using System;
using System.Collections.Generic;

namespace C14_Abstruct_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classlist = new List<Person>()
            {
             new Teacher {FName = "Hans", LName ="Mattin", Role ="Teacher"},
             new Student {FName = "Mattias", LName ="Karlsson"},
             new Student {FName = "Emil", LName ="Pettersson"},
             new Teacher {FName = "Karl", LName ="Gustaf" },


            };
            foreach (var person in classlist)
            {
                if (person is Teacher teacher)
                {
                    Console.WriteLine($"{teacher.FName} {teacher.LName}");
                }
                
                
            }
            Console.WriteLine("----------------------------------------");

            foreach (var person in classlist)
            {
                if (person is Student student)
                {
                    Console.WriteLine($"{student.FName} {student.LName}");
                }


            }



        }
    }
}
