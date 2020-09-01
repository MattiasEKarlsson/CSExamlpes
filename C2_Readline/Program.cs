using System;

namespace C2_Readline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            Console.Write($"Okej {name}, how old are you?: ");
            int age =0 ;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                while (true)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine($"Okej {name}, how old are you?: ");
                    age = Convert.ToInt32(Console.ReadLine());
                }
            }
            finally 
            {
                Console.WriteLine($"Okej {name} {age}");
            }

            Console.WriteLine($"Your name contains {name.Length} charachers.");
            Console.WriteLine($"{name}, where do you live?");
            var city = Console.ReadLine();

            Console.WriteLine($"My brother livies in {city}");





        }
    }
}
