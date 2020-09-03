using C14_Interfaces_2.Helpers;
using C14_Interfaces_2.Interfaces;
using System;

namespace C14_Interfaces_2
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
                    Console.WriteLine($"- Du har { license.NumberOfLicenses} st licenser att använda.");
            }
        }
    }
}
