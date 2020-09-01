using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeClac
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }



        public void AskForName()
        {
            Console.Write("What is your name?: ");
            Name = Console.ReadLine();
        }

        public void AskForAge()
        {
            Console.Write($"Okej, how old are you?: ");
            Age = 0;
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Invalid input");
                Console.WriteLine($"Okej {Name}, how old are you?: ");
                Age = Convert.ToInt32(Console.ReadLine());


            }
            finally
            {
                Console.WriteLine($"Okej, you age is {Age}");
            }


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
            Console.WriteLine($"Häfting jag är oxå {CalculateAge()}!!");
        
        }

        private int CalculateAge() 
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear) 
            {
                Age = Age - 1;
            }
            return Age;
                
            
        
        }
    }
}
