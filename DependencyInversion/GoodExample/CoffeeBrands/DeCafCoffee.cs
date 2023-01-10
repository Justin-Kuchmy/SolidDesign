using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversion.GoodExample.Interfaces;

namespace DependencyInversion.GoodExample.CoffeeBrands
{
    public class DeCafCoffee : Coffee, ICoffeeType
    {
        public string Brand { get; set; } = "Decaf";

        public bool IsOpen { get; set; } = false;

        public void BrewCoffee()
        {
            Console.WriteLine("Decaf Coffee Took 1.5 Minutes to Brew");
        }

        public void OpenPack()
        {
            IsOpen = true;
        }

    }
}
