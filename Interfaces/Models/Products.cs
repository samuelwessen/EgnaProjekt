using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    class Products : IShoppingItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }

        public bool OrderCompleted { get; private set; }

        public void ShippingItem()
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Varan {Name} har skickats iväg ");
                Console.WriteLine($"{Name} kostar totalt {Price}");
                Console.WriteLine("--------------------------------------");
                OrderCompleted = true;
            }



        }
    }
}
