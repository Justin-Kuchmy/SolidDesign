// See https://aka.ms/new-console-template for more information



using OpenClosed;
using OpenClosed.Strategies;

List<int> list = new List<int>();
list = populate(ref list);

//in the bad example if we wanted to add another strategy we would have to edit
//BadOpenCloseExample.cs to have another method and enum added then add it to the switch case.


BadOpenCloseExample badOpenCloseExample = new BadOpenCloseExample();
Console.WriteLine($"Iterate: {badOpenCloseExample.Calculate(list, BadOpenCloseExample.Strats.iterate_)}");
Console.WriteLine($"Random Index: {badOpenCloseExample.Calculate(list, BadOpenCloseExample.Strats.random_)}");
Console.WriteLine($"FirstThree: {badOpenCloseExample.Calculate(list, BadOpenCloseExample.Strats.firstThree_)}");


//In the Good example if we wanted to add another strategy we would just have to make a cs file for that new strategy which will 
//implement the interface, then add 1 more line in the main which will pass that new straegy so teh same Calculate method. 
// No need to change GoodOpenCloseExample
Console.WriteLine(new String('-', 35));
GoodOpenCloseExample goodOpenCloseExample = new GoodOpenCloseExample();
Console.WriteLine($"Iterate: {goodOpenCloseExample.Calculate(list, new IterateCount() )}");
Console.WriteLine($"Random Index: {goodOpenCloseExample.Calculate(list, new RandomCount() )}");
Console.WriteLine($"FirstThree: {goodOpenCloseExample.Calculate(list, new FirstThreeCount())}");
Console.WriteLine($"LastThree: {goodOpenCloseExample.Calculate(list, new LastThreeCount())}");


static List<int> populate(ref List<int> list)
{
    Random ran = new Random();
    for (int i = 0; i < 10; i++)
    {
        int num = ran.Next(1, 100 - 1);
        list.Add(num);
    }
   
    return list;
}