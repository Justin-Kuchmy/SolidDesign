using DependencyInversion.BadExample;
using DependencyInversion.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.GoodExample
{
    public class CoffeeMaker
    {
        ICoffee? _coffee;

        public CoffeeMaker()
        {
            this._coffee = CoffeeFactory.GetCoffeeInstance();
        }

        public void addCoffee(Coffee coffee)
        {
            this._coffee = coffee;
        }

        public void BrewCoffee(ICoffeeType coffeeBrand)
        {
            if (_coffee != null)
            {
                coffeeBrand.BrewCoffee();
            }
            else
            {
                Console.WriteLine("Please Add The Coffee First");
            }
          
               
        }
    }
}
