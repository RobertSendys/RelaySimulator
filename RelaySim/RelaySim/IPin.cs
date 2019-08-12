using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public interface IPin
    {
        IConnection this[string name] {get;}
    }
}
