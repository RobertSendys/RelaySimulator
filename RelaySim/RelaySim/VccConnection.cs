using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaySim
{
    public class VccConnection : IConnection
    {
        public string Name => "VCC";

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
            return Level.HIGH;
        }
    }
}
