using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    public interface IManaged : IGoodEmployee
    {
        IGoodEmployee Manager { get; set; }
        void AssignManager(IGoodEmployee manager);

    }
}
