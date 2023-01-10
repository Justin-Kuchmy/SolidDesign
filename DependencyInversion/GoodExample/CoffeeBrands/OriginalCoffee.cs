using DependencyInversion.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.GoodExample.CoffeeBrands
{
    public class OriginalCoffee : Coffee, ICoffeeType
    {
        public string Brand { get; set; } = "Original";

        public bool IsOpen { get; set; } = false;

        public void BrewCoffee()
        {
            Console.WriteLine("Original Coffee Took 2 Minutes to Brew");
        }

        public void OpenPack()
        {
            IsOpen = true;
        }


    }
}
