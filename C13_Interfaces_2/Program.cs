using C13_Interfaces_2.Helpers;
using System;

namespace C13_Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = SampleData.CartSampleIterms();

            foreach (var item in cart)
            {
                item.ShippingItem();
            }
        }
    }
}
