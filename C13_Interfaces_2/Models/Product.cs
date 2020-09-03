using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class Product : IShoppingItem
    {
        public string Id  {get; set;}
        public string Name{ get; set; }
        public string Description { get; set; }
        public bool Ordercompleted { get; private set; }

        public void ShippingIteam()
        {
            throw new NotImplementedException();
        }
        bool OrderCompleted = true;
        public void ShippingItem() 
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Varan {Name} har skickats");
                OrderCompleted = true;
            }
        
        
        }

    }
}
