using Interfaces.Helpers;
using Interfaces.Interfaces;
using Interfaces.Models;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {   
            
                      
            var cart = SampleData.CartSampleItems();

            foreach (var item in cart)
            {
                item.ShippingItem();

                if (item is ILicense license)
                    Console.WriteLine($"Du har { license.NumberOfLicenses} st licenser att använda");
            }
        }
    }
}
