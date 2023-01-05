using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    //Facade Pattern
    public class CorrectEmployee
    {
        Database db;

        //Some Type of Dependency Injection
        public CorrectEmployee(Database _db)
        {
            this.db = _db;
        }
        public double calculatePay(int empID)
        {
            return PayCalculator.calculatePay(db, empID);
        }
        public int reportHours(int empID)
        {
            //ssearch the database for a specific employee to find the number of hours they worked
            return HourReporter.reportHours(db, empID);
        }
        public int save()
        {
            return EmployeeSaver.Save(db);
            //Code to save changes in a database.
        }

    }

        public static class PayCalculator
        {
            public static double calculatePay(Database db, int empID)
            {      
                return db.Find(empID).HoursWorked * db.Find(empID).HourlyWage;
            }
        }
        public static class HourReporter
        {
            public static int reportHours(Database db, int empID)
            {
                return db.Find(empID).HoursWorked;
            }
        }
        public static class EmployeeSaver
        {
            public static int Save(Database db)
            {
                int saved = db.Save();
                return saved;

            }
        }

        public class Database
        {
            //this is just a mock database, to get different info based on the given EmployeeID
            public int HoursWorked { get; set; }
            public double HourlyWage { get; set; }
            public Database Find(int empID)
            {
                if (empID == 1)
                {
                    this.HoursWorked = 10;
                    this.HourlyWage = 10.00;
                }
                else
                {
                    this.HoursWorked = 20;
                    this.HourlyWage = 20.00;
                }
                return this;
            }
        public int Save() { return 1; }
            
        }

}
    