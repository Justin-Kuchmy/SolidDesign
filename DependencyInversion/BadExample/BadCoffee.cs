using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.BadExample
{
    public class BadCoffee
    {
        public string BadCoffeeType { get; set; } = "Original";
        public bool IsOpen { get; set; } = false;

        public void OpenBadPack()
        {
            Console.WriteLine("You Open the Bad Coffe Bag");
            IsOpen = true;
        }
    }
}
