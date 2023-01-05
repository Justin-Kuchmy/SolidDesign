using SingleResponsibility;

Database dbContext = new Database();
CorrectEmployee emp = new CorrectEmployee(dbContext);

Console.WriteLine($"Hours Worked: {emp.reportHours(1)}");
Console.WriteLine($"Weekly Earnings: ${emp.calculatePay(1)}.00");
Console.WriteLine(emp.save() > 0 ? "DB Saved" : "DB Not Saved");