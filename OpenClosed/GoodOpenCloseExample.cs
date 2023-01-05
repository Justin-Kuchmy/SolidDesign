using OpenClosed.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public  class GoodOpenCloseExample
    {
        public enum Strats
        {
            random_,
            iterate_,
            firstThree_
        }
        public int Calculate(List<int> list, IStrategy strat)
        {
            return strat.Count(list); ;
        }
    }
}
