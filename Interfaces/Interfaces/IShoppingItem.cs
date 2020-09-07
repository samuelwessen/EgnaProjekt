using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    interface IShoppingItem
    {
        string Id { get; set; }
        string Name { get; set; }
        string Discription { get; set; }

        int Price { get; set; }


        bool OrderCompleted { get; }
        void ShippingItem();
    }
}
