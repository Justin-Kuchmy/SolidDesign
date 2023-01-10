using DependencyInversion.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.GoodExample
{
    public class CoffeeFactory
    {
        public static ICoffee GetCoffeeInstance()
        {
            return new Coffee();
        }
    }
}
