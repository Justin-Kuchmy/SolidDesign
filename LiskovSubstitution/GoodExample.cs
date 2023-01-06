using LiskovSubstitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//   decimal baseAmount = 150M;
//   Salary = baseAmount * rank;

namespace LiskovSubstitution
{
    public class GoodCEO : GoodBaseEmployee, IGoodManager
    {
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Im reviewing a direct report's performance");
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }
    }
    public class GoodManager : GoodEmployee, IGoodManager
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

    public class GoodEmployee : GoodBaseEmployee, IManaged
    {
        public IGoodEmployee Manager { get; set; } = null;

        public void AssignManager(IGoodEmployee manager)
        {
            Manager = manager;
        }
    }

}
