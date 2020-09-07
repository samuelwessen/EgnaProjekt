using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    class Licenses : Customer ,IShoppingItem, ILicense
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
        public int NumberOfLicenses { get; set; } = 2;

        public bool OrderCompleted { get; private set; }


        
        

        public void ShippingItem()
        {
            var customer = new Customer();
            {
                customer.AskForName();
                customer.AskforEmailAdress();

            }
            
            Console.WriteLine($"Licensen för {Name} har skickats till {customer.CustomerEmailAdress}");
        }
    }
}
