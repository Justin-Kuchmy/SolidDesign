using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.BadExample
{
    public class BadCoffeeMaker
    {
        BadCoffee? coffee = null;
        public void addBadCoffee(BadCoffee coffee)
        {
            this.coffee = coffee;
        }

        public void BrewBadCoffee()
        {
            if (coffee != null)
            {
                if (coffee.IsOpen == false)
                {
                    Console.WriteLine("Open the Bad Coffee Pack First");
                }
                else
                {
                    switch (coffee.BadCoffeeType.ToLower())
                    {
                        case "original":
                            Console.WriteLine("Original Bad Coffee Took 2 Minutes to Brew");
                            break;
                        case "dark roast":
                            Console.WriteLine("Bad Dark Roast Coffee Took 2.5 Minutes to Brew");
                            break;
                        case "decaf":
                            Console.WriteLine("Bad Decaf Coffee Took 1.5 Minutes to Brew");
                            break;
                        default:
                            Console.WriteLine("Not a Valid Coffee Choice");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please Add The Coffee First");
            }
          
               
        }
    }
}
