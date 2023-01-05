using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Strategies
{
    public class FirstThreeCount : IStrategy
    {
        public int Count(List<int> list)
        {
            int total = 0;
            for (int i = 0; i < list.Count && i < 3; i++)
            {
                total += list[i];
            }
            return total;
        }
    }
}
