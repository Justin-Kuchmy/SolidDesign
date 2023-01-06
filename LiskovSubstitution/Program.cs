// See https://aka.ms/new-console-template for more information
using LiskovSubstitution;
using LiskovSubstitution.Interfaces;

Console.WriteLine("Bad Example"); 
Console.WriteLine("=================================================================================");
BadManager accountingVP = new BadManager();
accountingVP.FirstName = "Martin";
accountingVP.LastName = "Smith";
accountingVP.CalculatePerHourRate(2);


//BadEmployee employee = new BadCEO(); //This line will cause Line 19 to Error because
//the CEO Doesnt have a manager even though the CEO is an employee
//BadEmployee employee = new BadManager(); //This line will not cause the error becuase a Manager can still have a Manager
BadEmployee employee = new BadEmployee();
employee.FirstName = "John";
employee.LastName = "Doe";
employee.AssignManager(accountingVP);
employee.CalculatePerHourRate(2);

Console.WriteLine($"{employee.FirstName}'s Salary is {employee.Salary}/hr");
Console.WriteLine($"{accountingVP.FirstName}'s Salary is ${accountingVP.Salary}/hr");
Console.WriteLine("=================================================================================\n\n");



Console.WriteLine("Good Example");
Console.WriteLine("=================================================================================");
IGoodManager goodAccountingVP = new GoodCEO();
goodAccountingVP.FirstName = "Martin";
goodAccountingVP.LastName = "Smith";
goodAccountingVP.CalculatePerHourRate(2);

IManaged goodManager = new GoodManager();
goodManager.FirstName = "Bob";
goodManager.LastName = "Ross";
goodManager.AssignManager(goodAccountingVP);
goodManager.CalculatePerHourRate(2);


IManaged goodEmployee = new GoodEmployee();
goodEmployee.FirstName = "John";
goodEmployee.LastName = "Doe";
goodEmployee.AssignManager(goodManager);
goodEmployee.CalculatePerHourRate(2);

Console.WriteLine($"{goodEmployee.FirstName}'s Salary is ${goodEmployee.Salary}/hr");
Console.WriteLine($"{goodManager.FirstName}'s Salary is ${goodManager.Salary}/hr");
Console.WriteLine($"{goodAccountingVP.FirstName}'s Salary is ${goodAccountingVP.Salary}/hr");
Console.WriteLine("=================================================================================");
