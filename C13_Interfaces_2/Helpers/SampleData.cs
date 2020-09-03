using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleIterms() 
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "232323", Name = "OldPhone", Description = "Iphone6" });
            output.Add(new Product { Id = "122", Name = "NewPhone", Description = "Iphone11" });
            output.Add(new Product { Id = "1", Name = "Phone", Description = "Iphone9" });

            output.Add(new Licens { Id = "", Name = "", NumberofLicens =  });
          

            return output;
        }

    }
}
