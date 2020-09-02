using System;
using System.Text.RegularExpressions;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("What is your name?: ");
            person.Name = Console.ReadLine();

            rrerun:                                                         //Loop för try/catch
            Console.Write($"Okej {person.Name}, how old are you?: ");
            person.Age = 0;
            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Invalid input");
                goto rrerun;                                          //Loop
            }

           

            Console.WriteLine($"Your name contains {person.Name.Length} charachers.");
            Console.WriteLine($"{person.Name}, where do you live?");
            person.City = Console.ReadLine();

            Console.WriteLine($"My brother livies in {person.City}");
        }
    }
}
