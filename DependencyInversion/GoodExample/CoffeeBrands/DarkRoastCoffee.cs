using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversion.GoodExample.Interfaces;

namespace DependencyInversion.GoodExample.CoffeeBrands
{
    public class DarkRoastCoffee : Coffee, ICoffeeType
    {
        public string Brand { get; set; } = "Dark Roast";
        public bool IsOpen { get; set; } = false;

        public void BrewCoffee()
        {
            Console.WriteLine("Dark Roast Coffee Took 2.5 Minutes to Brew");
        }

        public void OpenPack()
        {
            IsOpen = true;
        }
    }
}
