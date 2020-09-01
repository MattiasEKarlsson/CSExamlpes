using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSetters
{
    class Person
    {
        public string Name { get;}
        public int Age => CalculateAge();
        public string City { get;}
        public DateTime DateOfBirth { get; set; }


        public void AskForName()
        {
            Console.Write("What is your name?: ");
            Name = Console.ReadLine();
        }

        public void NameCont()
        {
            Console.WriteLine($"Your name contains {Name.Length} charachers.");
        }

        public void AskForCity()
        {
            Console.WriteLine($"{Name}, where do you live?");
            City = Console.ReadLine();

            Console.WriteLine($"My brother livies in {City}");

        }

        public void AskForDateOfBirth()
        {
            Console.Write("When were u born?:");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Enter like 2000-01-01");
                try
                {
                    Console.Write("Again, enter like 2000-01-01");
                }
                catch
                {
                    Console.Write("U are a retard!!");
                }
            }
            Console.WriteLine($"Häfting jag är oxå {Age}!!");

        }

        private int CalculateAge()
        {
            int _age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                _age = _age - 1;
            }
            return _age;



        }
    }
}

