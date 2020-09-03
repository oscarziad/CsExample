using C14_Interfaces_2.Interfaces;
using C14_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C14_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "1007573", Name = "Apple Airpods (2019)", Description = "AirPods med laddningsetui" });
            output.Add(new Product { Id = "1013033", Name = "SodaStream Genesis Megapack Titan/Silver", Description = "Sodastream i modern design" });
            output.Add(new Product { Id = "1005300", Name = "Day Vattenflaska 500ML", Description = "Vattenflaska 500 ml" });

            output.Add(new License { Id = "5010877355", Name = "Microsoft WIndows 10 Pro 64-Bit Sve OEM", Description = "Program Microsoft WIndows 10 Pro 64-Bit Sve OEM", NumberOfLicenses = 1 });
            output.Add(new License { Id = "5011108149", Name = "Windows Server Standard 2019", Description = "Windows Server Standard Nykel", NumberOfLicenses = 5 });

            return output;
        }
    }
}
