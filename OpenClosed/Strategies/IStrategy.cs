using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Strategies
{
    public interface IStrategy
    {
        public int Count(List<int> list);
    }
}
