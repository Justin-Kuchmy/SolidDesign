using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Strategies
{
    public class RandomCount : IStrategy
    {
        public int Count(List<int> list)
        {
            Random ran = new Random();
            int num = ran.Next(1, list.Count - 1);
            return list[num];
        }
    }
}
