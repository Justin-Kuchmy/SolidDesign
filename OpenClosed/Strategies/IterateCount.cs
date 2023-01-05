using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Strategies
{
    public class IterateCount : IStrategy
    {
        public int Count(List<int> list)
        {
            int total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i];
            }

            return total;
        }
    }
}
