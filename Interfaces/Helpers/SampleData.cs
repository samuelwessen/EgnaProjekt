using Interfaces.Interfaces;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();
            output.Add(new Products { Id = "11", Name = "RazerExtreme Mouse", Discription = "Gamingmouse", Price = 699 });
            output.Add(new Products { Id = "50", Name = "Steelseries keybord x200", Discription = "ComputerKeybord", Price = 1249 });
            output.Add(new Products { Id = "12", Name = "HDMI Cable 2m", Discription = "HDMI kabel 2m", Price = 129 });

            output.Add(new Licenses { Id = "110", Name = "MSWord2020", Discription = "MicrosoftWord 2020", NumberOfLicenses = 2, Price = 2499 });
            output.Add(new Licenses { Id = "120", Name = "Office2020", Discription = "Offie 2020", NumberOfLicenses = 1, Price = 1499 });
            return output;
        }

    }
}
