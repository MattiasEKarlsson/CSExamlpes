using System;
using System.Collections.Generic;
using System.Text;

namespace c4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }



        public void AskForName() 
        {
            Console.Write("What is your name?: ");
            Name = Console.ReadLine();
        }

        public void AskForAge() 
        {
            Console.Write($"Okej {Name}, how old are you?: ");
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
                Console.WriteLine($"Okej {Name} {Age}");
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

        
    }
}
