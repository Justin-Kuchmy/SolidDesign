﻿using LiskovSubstitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public abstract class GoodBaseEmployee : IGoodEmployee
    {
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + rank * 2;
        }
    }
}
