using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public class GndConnection : IConnection
    {
        public string Name => "GND";

        public void Connect(IConnection value)
        {
            throw new NotSupportedException(Name);
        }

        public void Disconnect(IConnection value)
        {
            throw new NotSupportedException(Name);
        }

        public Level Read(int dep = 0)
        {
            return Level.LOW;
        }
    }
}
