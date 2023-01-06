using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class BadCEO : BadEmployee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }
        public override void AssignManager(BadEmployee manager)
        {
            throw new InvalidOperationException("The CEO has no Manager.");
        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Im reviewing a direct report's performance");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're Fired");
        }
    }
    public class BadManager : BadEmployee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + rank * 4;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Im reviewing a direct report's performance");
        }
    }

    public class BadEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BadEmployee? Manager { get; set; } = null;
        public decimal Salary { get; set; }
        public virtual void AssignManager(BadEmployee manager)
        {
            this.Manager = manager;
        }
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + rank * 2;
        }

    }


}
