using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class Licens : ILicens
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberofLicens { get; set; } = 1;
        
        public void ShippingIteam()
        {

            Console.WriteLine($"Licensen för {Name} har skickats till");

        }
    }
}
