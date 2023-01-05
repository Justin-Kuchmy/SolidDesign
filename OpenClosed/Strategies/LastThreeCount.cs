using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Strategies
{
    public class LastThreeCount : IStrategy
    {
        public int Count(List<int> list)
        {
            int total = 0;
            for (int i = list.Count-1; i > list.Count-4; i--)
            {
                total += list[i];
            }
            return total;
        }
    }
}
