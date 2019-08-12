using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public interface IConnection
    {
        string Name { get; }
        Level Read(int dep = 0);
        void Connect(IConnection value);
        void Disconnect(IConnection value);
    }
}
