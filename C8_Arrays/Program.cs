using System;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many sibilings do u have?:");
            var numberofSiblings = Convert.ToInt32(Console.ReadLine());

            if (numberofSiblings < 1)
            {
                Console.WriteLine("Okej, inga syskon");
            }
            else
            {
                string[] siblings = new string[numberofSiblings];

                if (numberofSiblings == 1)
                {
                    Console.Write("Vad heter ditt syskon?: ");
                    siblings[0] = Console.ReadLine();
                }

                else
                {
                    for (int i = 0; i < numberofSiblings; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("Whats yours first siblings name?: ");
                        }
                        else 
                        {
                            Console.Write("And your next siblings name?: ");
                        }
                        siblings[i] = Console.ReadLine();

                    }

                }
                if (numberofSiblings == 1)
                {
                    Console.WriteLine($"Ditt syskon heter:");
                }
                else
                {
                    Console.WriteLine($"Dina syskon heter:");
                }

                foreach (var sibling  in siblings)
                {
                    Console.WriteLine($"{sibling}");
                }

            }
            
        }

    }
}
