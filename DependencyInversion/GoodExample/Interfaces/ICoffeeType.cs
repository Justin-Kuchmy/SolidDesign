using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.GoodExample.Interfaces
{
    public interface ICoffeeType
    {
        public string Brand { get; set; }
        public void BrewCoffee();
    }
}
