using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Interfaces.Models
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerEmailAdress { get; set; } 

        public string AskForName()
        {
            Console.WriteLine("Hello please type in your name");
            CustomerName = Console.ReadLine();
            return CustomerName;
        }

        public string AskforEmailAdress()
        {
            Console.WriteLine($"Hello {CustomerName} please type in your emailadress ");
            CustomerEmailAdress = Console.ReadLine();
            return CustomerEmailAdress;
        }

    }
}
