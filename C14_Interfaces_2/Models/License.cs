using C14_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C14_Interfaces_2.Models
{
    class License : ILicense, IShoppingItem
    {
        public string Name { get; set; }
        public int NumberOfLicenses { get; set; } = 1;
        public string Id { get; set; }
        public string Description { get; set; }

        public bool OrderCompleted { get; set; }

        public void ShippingItem()
        {
            Console.WriteLine($"Lincensen för {Name} har skickats till e-postadressen,");
        }
    }
}
