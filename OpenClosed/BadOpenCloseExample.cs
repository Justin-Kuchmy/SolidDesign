using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class BadOpenCloseExample
    {
        public enum Strats
        {
            random_,
            iterate_,
            firstThree_
        }
        public int Calculate(List<int> list, Strats strat)
        {
            int result = 0;
            switch (strat)
            {
                case Strats.random_:
                    result = randomCount(list);
                    break;
                case Strats.iterate_:
                    result = iterateCount(list);
                    break;

                case Strats.firstThree_:
                    result = firstThreeCount(list);
                    break;
            }
            return result;
        }

        public int iterateCount(List<int> count)
        {
            int total = 0;
            for (int i = 0; i < count.Count; i++)
            {
                total += count[i];
            }

            return total;
        }

        public int randomCount(List<int> count)
        {
            Random ran = new Random();
            int num = ran.Next(1, count.Count - 1);
            return count[num];
        }

        public int firstThreeCount(List<int> count)
        {
            int total = 0;
            for (int i = 0; i < count.Count && i < 3; i++)
            {
                total += count[i];
            }
            return total;
        }
    }
}
