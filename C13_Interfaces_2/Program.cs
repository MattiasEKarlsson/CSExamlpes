﻿using C13_Interfaces_2.Helpers;
using C13_Interfaces_2.Models;
using System;

namespace C13_Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = SampleData.CartSampleItems();

            foreach (var item in cart)
            {
                item.ShippingItem();

                if (item is ILicense License)
                    Console.WriteLine($"- Du har { License.NumberOfLicenses } st licenser att använda.");
            }
        }
    }

    
}
