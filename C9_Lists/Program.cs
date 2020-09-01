using System;
using System.Collections.Generic;

namespace C9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hassiblings;
            Console.Write("Do u have any siblings?[yes][no]: ");
            var _siblingrespons = Console.ReadLine();

            switch (_siblingrespons.ToLower())
            {
                case "yes":
                    _hassiblings = true;
                    break;

                case "no":
                    _hassiblings = false;
                    break;

                default:
                    _hassiblings = false;
                    break;
            }

            if (!_hassiblings)
            {
                Console.WriteLine("Okej, inga syskon");
            }
            else 
            {
                Console.Write("Hur många har du?:");
                int _numberofsiblings = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if (_numberofsiblings == 1)
                {
                    Console.Write("Vad heter ditt syskon");
                    siblings.Add(Console.ReadLine());

                    Console.WriteLine($"Okej ditt syskon heter{siblings[0]}");
                }
                else
                {
                    Console.Write("Vad heter alla din syskon?");
                    var _respons = Console.ReadLine();
                    var names = _respons.Replace(" ", " ").Split(",");
                }
                foreach (var name in siblings)
                {
                    siblings.Add(name);
                }

                Console.Write($"Okej, så dinna syskon heter");
                foreach (var sibling in siblings)
                {
                    Console.Write($"{sibling}");
                }
            
            
            }











        }

    }
}
