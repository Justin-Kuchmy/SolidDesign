// See https://aka.ms/new-console-template for more information
using DependencyInversion.BadExample;
using DependencyInversion.GoodExample;
using DependencyInversion.GoodExample.CoffeeBrands;

BadCoffee BadCoffee1 = new BadCoffee();
BadCoffee1.BadCoffeeType = "DeCaf";

BadCoffee BadCoffee2 = new BadCoffee();
BadCoffee2.BadCoffeeType = "Original";

BadCoffee BadCoffee3 = new BadCoffee();
BadCoffee3.BadCoffeeType = "Dark Roast";


BadCoffeeMaker BadCoffeeMaker = new BadCoffeeMaker();
BadCoffee1.OpenBadPack();
BadCoffeeMaker.addBadCoffee(BadCoffee1);
BadCoffeeMaker.BrewBadCoffee();

BadCoffee2.OpenBadPack();
BadCoffeeMaker.addBadCoffee(BadCoffee2);
BadCoffeeMaker.BrewBadCoffee();

BadCoffee3.OpenBadPack();
BadCoffeeMaker.addBadCoffee(BadCoffee3);
BadCoffeeMaker.BrewBadCoffee();

Console.WriteLine(new String('=', 50));

DeCafCoffee GoodCoffee1 = new DeCafCoffee();
GoodCoffee1.Brand = "decaf";

OriginalCoffee GoodCoffee2 = new OriginalCoffee();
GoodCoffee2.Brand = "original";

DarkRoastCoffee GoodCoffee3 = new DarkRoastCoffee();
GoodCoffee3.Brand = "dark roast";

CoffeeMaker CoffeeMaker = new CoffeeMaker();
GoodCoffee1.OpenPack();
CoffeeMaker.addCoffee(GoodCoffee1);
CoffeeMaker.BrewCoffee(GoodCoffee1);

GoodCoffee2.OpenPack();
CoffeeMaker.addCoffee(GoodCoffee2);
CoffeeMaker.BrewCoffee(GoodCoffee2);

GoodCoffee3.OpenPack();
CoffeeMaker.addCoffee(GoodCoffee3);
CoffeeMaker.BrewCoffee(GoodCoffee3);